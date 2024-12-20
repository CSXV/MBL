CREATE PROCEDURE SP_UpdateAuthor
    @AuthorID INT,                         -- The AuthorID to identify the author to update
    @FirstName NVARCHAR(50) = NULL,         -- New first name for the author (optional)
    @LastName NVARCHAR(50) = NULL,          -- New last name for the author (optional)
    @Email NVARCHAR(50) = NULL,             -- New email for the author (optional)
    @Phone NVARCHAR(15) = NULL,             -- New phone number (optional)
    @Website NVARCHAR(255) = NULL           -- New website URL (optional)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        -- Update the author details only for non-NULL input parameters
        UPDATE Authors
        SET 
            FirstName = ISNULL(@FirstName, FirstName),         -- Update first name if provided
            LastName = ISNULL(@LastName, LastName),             -- Update last name if provided
            ContactInfoID = (
                CASE 
                    WHEN @Email IS NOT NULL OR @Phone IS NOT NULL OR @Website IS NOT NULL
                    THEN (SELECT ContactInfoID FROM ContactInfo WHERE ContactInfoID = Authors.ContactInfoID)
                    ELSE Authors.ContactInfoID
                END
            )  -- Update ContactInfoID based on the provided fields, if required
        WHERE AuthorID = @AuthorID;

        -- If any of the contact fields are updated, also update the ContactInfo table
        IF @Email IS NOT NULL OR @Phone IS NOT NULL OR @Website IS NOT NULL
        BEGIN
            UPDATE ContactInfo
            SET 
                Email = ISNULL(@Email, Email),
                Phone = ISNULL(@Phone, Phone),
                Website = ISNULL(@Website, Website)
            WHERE ContactInfoID = (SELECT ContactInfoID FROM Authors WHERE AuthorID = @AuthorID);
        END

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
