CREATE PROCEDURE SP_UpdateUser
    @UserID INT,                          -- The UserID to identify the user to update
    @UserName NVARCHAR(10) = NULL,         -- New username (optional)
    @Password NVARCHAR(64) = NULL,         -- New password (optional)
    @IsActive BIT = NULL                   -- New active status (optional)
AS
BEGIN
    -- Start the transaction
    BEGIN TRY
        BEGIN TRANSACTION

        -- Update the user details only for non-NULL input parameters
        UPDATE Users
        SET 
            UserName = ISNULL(@UserName, UserName),   -- Update UserName if provided
            Password = ISNULL(@Password, Password),   -- Update Password if provided
            IsActive = CASE
                        WHEN @IsActive IS NOT NULL THEN @IsActive  -- Only update IsActive if provided
                        ELSE IsActive
                      END
        WHERE UserID = @UserID;

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
