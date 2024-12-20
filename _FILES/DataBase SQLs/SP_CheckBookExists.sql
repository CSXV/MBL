CREATE PROCEDURE SP_CheckBookExists
@BookID INT AS BEGIN
    IF EXISTS(SELECT * FROM Books WHERE BookID = @BookID)
        RETURN 1;  -- Person exists
	ELSE
        RETURN 0;  -- Person does not exist
END