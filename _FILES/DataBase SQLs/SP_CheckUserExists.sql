CREATE PROCEDURE SP_CheckUserExists
@UserID INT AS BEGIN
    IF EXISTS(SELECT * FROM Users WHERE UserID = @UserID)
        RETURN 1;  -- Person exists
	ELSE
        RETURN 0;  -- Person does not exist
END