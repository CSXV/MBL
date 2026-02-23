CREATE PROCEDURE sp_UpdateBook
    @BookID INT,
    @PublisherID INT,
    @AuthorID INT,
    @Title NVARCHAR(255),
    @ISBN NVARCHAR(13),
    @Edition TINYINT,
    @PublicationDate DATE,
    @Language NVARCHAR(20),
    @Cover NVARCHAR(255),
    @Pages INT,
    @Description NVARCHAR(MAX),
    @Series NVARCHAR(255),
    @TagNames NVARCHAR(MAX), -- Comma-separated list of Tag names to associate with the book
    @TopicName NVARCHAR(50) -- The Topic name to associate with the book
AS
BEGIN
    -- Begin transaction to ensure all operations are atomic
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Step 1: Update the Book
        UPDATE Books
        SET 
            PublisherID = @PublisherID,
            AuthorID = @AuthorID,
            Title = @Title,
            ISBN = @ISBN,
            Edition = @Edition,
            PublicationDate = @PublicationDate,
            Language = @Language,
            Cover = @Cover,
            Pages = @Pages,
            Description = @Description,
            Series = @Series
        WHERE BookID = @BookID;

        -- Step 2: Delete existing BookTags (remove all tags associated with the book)
        DELETE FROM BookTags WHERE BookID = @BookID;

        -- Step 3: Insert new BookTags (using the comma-separated list of Tag names)
        IF (@TagNames IS NOT NULL AND @TagNames != '')
        BEGIN
            DECLARE @TagName NVARCHAR(50), @TagList NVARCHAR(MAX), @TagID INT;
            SET @TagList = @TagNames;

            -- Loop through each tag name in the list
            WHILE LEN(@TagList) > 0
            BEGIN
                -- Get the tag name from the list
                SET @TagName = LEFT(@TagList, CHARINDEX(',', @TagList + ',') - 1);
                SET @TagList = STUFF(@TagList, 1, CHARINDEX(',', @TagList + ','), '');

                -- Check if the tag exists, if not, insert it
                IF NOT EXISTS (SELECT 1 FROM Tags WHERE TagName = @TagName)
                BEGIN
                    -- Insert the tag into Tags table
                    INSERT INTO Tags (TagName) VALUES (@TagName);
                    -- Get the TagID for the newly inserted tag
                    SELECT @TagID = SCOPE_IDENTITY();
                END
                ELSE
                BEGIN
                    -- If the tag already exists, get the TagID
                    SELECT @TagID = TagID FROM Tags WHERE TagName = @TagName;
                END

                -- Insert the tag association into BookTags
                INSERT INTO BookTags (BookID, TagID) VALUES (@BookID, @TagID);
            END
        END

        -- Step 4: Delete existing BookTopics (remove all topics associated with the book)
        DELETE FROM BookTopics WHERE BookID = @BookID;

        -- Step 5: Insert or create the Topic (one single topic by name)
        IF (@TopicName IS NOT NULL AND @TopicName != '')
        BEGIN
            DECLARE @TopicID INT;

            -- Check if the Topic exists, if not, insert it
            IF NOT EXISTS (SELECT 1 FROM Topics WHERE TopicName = @TopicName)
            BEGIN
                -- Insert the topic into Topics table
                INSERT INTO Topics (TopicName) VALUES (@TopicName);
                -- Get the TopicID for the newly inserted topic
                SELECT @TopicID = SCOPE_IDENTITY();
            END
            ELSE
            BEGIN
                -- If the topic already exists, get the TopicID
                SELECT @TopicID = TopicID FROM Topics WHERE TopicName = @TopicName;
            END

            -- Insert the topic association into BookTopics
            INSERT INTO BookTopics (BookID, TopicID) VALUES (@BookID, @TopicID);
        END

        -- Commit the transaction if everything is successful
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- If an error occurs, roll back the transaction
        ROLLBACK TRANSACTION;
        -- Return the error message
        THROW;
    END CATCH
END;
