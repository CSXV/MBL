CREATE PROCEDURE SP_UpdatePublisher
    @PublisherID INT,                      -- The PublisherID to identify the publisher to update
    @Name NVARCHAR(100) = NULL,             -- New name for the publisher (optional)
    @Email NVARCHAR(50) = NULL,            -- New email for the publisher (optional)
    @Phone NVARCHAR(15) = NULL,            -- New phone number (optional)
    @Website NVARCHAR(255) = NULL          -- New website URL (optional)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        -- Update the publisher details only for non-NULL input parameters
        UPDATE Publishers
        SET 
            Name = ISNULL(@Name, Name),             -- Update publisher name if provided
            ContactInfoID = (
                CASE 
                    WHEN @Email IS NOT NULL OR @Phone IS NOT NULL OR @Website IS NOT NULL
                    THEN (SELECT ContactInfoID FROM ContactInfo WHERE ContactInfoID = Publishers.ContactInfoID)
                    ELSE Publishers.ContactInfoID
                END
            )  -- Update ContactInfoID based on the provided fields, if required
        WHERE PublisherID = @PublisherID;

        -- If any of the contact fields are updated, also update the ContactInfo table
        IF @Email IS NOT NULL OR @Phone IS NOT NULL OR @Website IS NOT NULL
        BEGIN
            UPDATE ContactInfo
            SET 
                Email = ISNULL(@Email, Email),
                Phone = ISNULL(@Phone, Phone),
                Website = ISNULL(@Website, Website)
            WHERE ContactInfoID = (SELECT ContactInfoID FROM Publishers WHERE PublisherID = @PublisherID);
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
