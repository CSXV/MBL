CREATE PROCEDURE UpdateUserStatus
    @UserID INT,
    @IsActive BIT
AS
BEGIN
    UPDATE Users
    SET IsActive = @IsActive
    WHERE UserID = @UserID;
END;
