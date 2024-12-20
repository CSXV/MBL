USE [MyBookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewPublisher]    Script Date: 12-05-1446 14:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_AddNewPublisher]
    @PublisherName NVARCHAR(100),
    @Email NVARCHAR(50) = NULL,
    @Phone NVARCHAR(15) = NULL,
    @Website NVARCHAR(255) = NULL,
	@PublisherID INT OUT
AS
BEGIN
    -- Begin transaction to ensure atomicity
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insert contact information for the publisher into the ContactInfo table
        INSERT INTO ContactInfo (Email, Phone, Website)
        VALUES (@Email, @Phone, @Website);

        -- Get the ContactInfoID of the newly inserted record
        DECLARE @ContactInfoID INT;
        SET @ContactInfoID = SCOPE_IDENTITY();

        -- Insert the publisher into the Publishers table
        INSERT INTO Publishers (ContactInfoID, Name)
        VALUES (@ContactInfoID, @PublisherName);

		SET @PublisherID = SCOPE_IDENTITY();

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
