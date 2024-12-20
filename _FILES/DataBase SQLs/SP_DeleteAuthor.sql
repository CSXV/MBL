CREATE PROCEDURE SP_DeleteAuthor 
    @AuthorID INT
AS BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Step 1: Delete all books associated with the author.
        DELETE FROM Books
        WHERE BookID IN (SELECT BookID FROM BookAuthors WHERE AuthorID = @AuthorID);

        -- Step 2: Delete all associations between books and the author.
        DELETE FROM BookAuthors 
        WHERE AuthorID = @AuthorID;

        -- Step 3: delete the author.
        DELETE FROM Authors 
        WHERE AuthorID = @AuthorID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;