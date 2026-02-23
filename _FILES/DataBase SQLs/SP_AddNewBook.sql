CREATE PROCEDURE SP_AddNewBook
    @Title NVARCHAR(255),
    @ISBN NVARCHAR(13) = NULL,
    @Edition TINYINT = NULL,
    @PublicationDate DATE = NULL,
    @Language NVARCHAR(20) = NULL,
    @Cover NVARCHAR(255) = NULL,
    @Pages INT = NULL,
    @Description NVARCHAR(MAX) = NULL,
    @Series NVARCHAR(255) = NULL,
    @PublisherID INT,
    @AuthorID INT,
    @TopicName NVARCHAR(50),  -- The topic name (only one topic)
    @TagNames NVARCHAR(MAX),   -- A comma-separated list of tags
	@BookID INT OUTPUT

AS BEGIN
    SET NOCOUNT ON;

    -- Start a transaction
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Step 1: Insert Topic if it doesn't exist
        DECLARE @TopicID INT;
        IF NOT EXISTS (SELECT 1 FROM Topics WHERE TopicName = @TopicName)
        BEGIN
            INSERT INTO Topics (TopicName)
            VALUES (@TopicName);
        END

        -- Get the TopicID after ensuring the topic exists
        SELECT @TopicID = TopicID FROM Topics WHERE TopicName = @TopicName;

        -- Step 2: Insert Tags if they don't exist and get TagIDs
        DECLARE @TagName NVARCHAR(50);
        DECLARE @TagID INT;
        DECLARE @TagCursor CURSOR;
        SET @TagCursor = CURSOR FOR
        SELECT value FROM STRING_SPLIT(@TagNames, ',');

        OPEN @TagCursor;
        FETCH NEXT FROM @TagCursor INTO @TagName;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Remove any leading/trailing spaces
            SET @TagName = LTRIM(RTRIM(@TagName));

            -- Check if tag exists, if not insert it
            IF NOT EXISTS (SELECT 1 FROM Tags WHERE TagName = @TagName)
            BEGIN
                INSERT INTO Tags (TagName)
                VALUES (@TagName);
            END

            -- Get the TagID after ensuring the tag exists
            SELECT @TagID = TagID FROM Tags WHERE TagName = @TagName;

            -- Insert the tag-book association (this will be done later)
            -- We'll insert the Book first and then associate tags

            FETCH NEXT FROM @TagCursor INTO @TagName;
        END

        CLOSE @TagCursor;
        DEALLOCATE @TagCursor;

        -- Step 3: Insert the new book
        INSERT INTO Books (PublisherID, AuthorID, Title, ISBN, Edition, PublicationDate, Language, Cover, Pages, Description, Series)
        VALUES (@PublisherID, @AuthorID, @Title, @ISBN, @Edition, @PublicationDate, @Language, @Cover, @Pages, @Description, @Series);

        -- Get the BookID of the inserted book
        SELECT @BookID = SCOPE_IDENTITY();

        -- Step 4: Insert the book-topic association
        INSERT INTO BookTopics (BookID, TopicID)
        VALUES (@BookID, @TopicID);

        -- Step 5: Insert Book-Tag Associations
        SET @TagCursor = CURSOR FOR
        SELECT value FROM STRING_SPLIT(@TagNames, ',');

        OPEN @TagCursor;
        FETCH NEXT FROM @TagCursor INTO @TagName;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Remove any leading/trailing spaces
            SET @TagName = LTRIM(RTRIM(@TagName));

            -- Check if tag exists, if not insert it
            IF NOT EXISTS (SELECT 1 FROM Tags WHERE TagName = @TagName)
            BEGIN
                INSERT INTO Tags (TagName)
                VALUES (@TagName);
            END

            -- Get the TagID after ensuring the tag exists
            SELECT @TagID = TagID FROM Tags WHERE TagName = @TagName;

            -- Insert the tag-book association
            INSERT INTO BookTags (BookID, TagID)
            VALUES (@BookID, @TagID);

            FETCH NEXT FROM @TagCursor INTO @TagName;
        END

        CLOSE @TagCursor;
        DEALLOCATE @TagCursor;

        -- Commit the transaction if all operations were successful
        COMMIT TRANSACTION;
        
        -- Return the newly inserted BookID
        SELECT @BookID AS NewBookID;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if an error occurs
        ROLLBACK TRANSACTION;

        -- Optionally, return the error message
        THROW;
    END CATCH;
END;
