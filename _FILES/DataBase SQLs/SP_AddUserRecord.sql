ALTER PROCEDURE [dbo].[SP_AddUserRecord]
    @UserID INT,
    @BookID INT,
    @State TINYINT = NULL, -- The current state of the book (1 = waiting, 2 = reading, etc.)
    @Difficulty TINYINT = NULL,  -- The difficulty level (1 = easy, 2 = medium, 3 = hard)
    @Rating TINYINT = NULL,
    @ReadingDuration INT = NULL,
    @FinishDate DATE = NULL,
    @Comments NVARCHAR(MAX) = NULL,
	@RecordID INT OUT
AS BEGIN
    -- Start the transaction
    BEGIN TRY
        BEGIN TRANSACTION

        -- Insert a new record into the UsersRecords table
        INSERT INTO UsersRecords
            (UserID, BookID, State, Difficulty, Rating, ReadingDuration, FinishDate, Comments)
        VALUES
            (@UserID, @BookID, @State, @Difficulty, @Rating, @ReadingDuration, @FinishDate, @Comments);

			SET @RecordID = SCOPE_IDENTITY();
        -- Commit the transaction if everything is fine
        COMMIT TRANSACTION;
        
    END TRY
    BEGIN CATCH
        -- Rollback the transaction in case of an error
        ROLLBACK TRANSACTION;

        -- Re-raise the error to be caught by the application or user
        THROW;
    END CATCH
END;
