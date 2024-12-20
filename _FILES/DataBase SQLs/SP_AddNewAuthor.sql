USE [MyBookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewAuthor]    Script Date: 12-05-1446 11:54:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_AddNewAuthor]
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(50) = NULL,
    @Phone NVARCHAR(15) = NULL,
    @Website NVARCHAR(255) = NULL,
	@AuthorID INT OUTPUT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insert contact information for the author into the ContactInfo table
        INSERT INTO ContactInfo (Email, Phone, Website)
        VALUES (@Email, @Phone, @Website);

        -- Get the ContactInfoID of the newly inserted record
        DECLARE @ContactInfoID INT;
        SET @ContactInfoID = SCOPE_IDENTITY();

        -- Insert the author into the Authors table
        INSERT INTO Authors (ContactInfoID, FirstName, LastName)
        VALUES (@ContactInfoID, @FirstName, @LastName);

		SET @AuthorID = SCOPE_IDENTITY();

        -- Commit transaction if everything was successful
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction in case of an error
        ROLLBACK TRANSACTION;

        -- Return error message
        THROW;
    END CATCH;
END;
