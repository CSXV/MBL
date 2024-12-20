CREATE PROCEDURE SP_CheckUserExistsByName
@UserName NVARCHAR(50) AS BEGIN
    IF EXISTS(SELECT * FROM Users WHERE UserName = @UserName)
        RETURN 1;  -- Person exists
	ELSE
        RETURN 0;  -- Person does not exist
END