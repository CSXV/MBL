CREATE PROCEDURE SP_DeleteBook
    @BookID INT
AS BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Step 1: Delete all records in BookTags
        DELETE FROM BookTags WHERE BookID = @BookID;

        -- Step 2: Delete all records in BookTopics
        DELETE FROM BookTopics WHERE BookID = @BookID;

        -- Step 3: Delete all records in UsersRecords
        DELETE FROM UsersRecords WHERE BookID = @BookID;

        -- Step 4: Delete the Book itself
        DELETE FROM Books WHERE BookID = @BookID;

        -- Commit the transaction if all deletions are successful
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- If an error occurs, roll back the transaction
        ROLLBACK TRANSACTION;
        -- Return the error message
        THROW;
    END CATCH
END;
