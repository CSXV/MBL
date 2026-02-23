CREATE PROCEDURE SP_DeletePublisher
    @PublisherID INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY

        DELETE FROM Books
        WHERE PublisherID = @PublisherID;

        DELETE FROM Publishers
        WHERE PublisherID = @PublisherID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
