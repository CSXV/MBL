CREATE PROCEDURE SP_UpdateUserRecord
    @UserRecordID INT,                    -- The UserRecordID to identify the user's record to update
    @State TINYINT = NULL,                 -- New state for the book (optional)
    @Difficulty TINYINT = NULL,            -- New difficulty (optional)
    @Rating TINYINT = NULL,                -- New rating (optional)
    @ReadingDuration INT = NULL,           -- New reading duration (optional)
    @FinishDate DATE = NULL,               -- New finish date (optional)
    @Comments NVARCHAR(MAX) = NULL         -- New comments (optional)
AS
BEGIN
    -- Start the transaction
    BEGIN TRY
        BEGIN TRANSACTION

        -- Update the user record details only for non-NULL input parameters
        UPDATE UsersRecords
        SET 
            State = ISNULL(@State, State),                          -- Update State if provided
            Difficulty = ISNULL(@Difficulty, Difficulty),            -- Update Difficulty if provided
            Rating = ISNULL(@Rating, Rating),                        -- Update Rating if provided
            ReadingDuration = ISNULL(@ReadingDuration, ReadingDuration),  -- Update ReadingDuration if provided
            FinishDate = ISNULL(@FinishDate, FinishDate),             -- Update FinishDate if provided
            Comments = ISNULL(@Comments, Comments)                   -- Update Comments if provided
        WHERE UserRecordID = @UserRecordID;

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
