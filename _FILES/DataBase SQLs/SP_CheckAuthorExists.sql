CREATE PROCEDURE SP_CheckAuthorExists
@AuthorID INT AS BEGIN
    IF EXISTS(SELECT * FROM Authors WHERE AuthorID = @AuthorID)
        RETURN 1;  -- Person exists
	ELSE
        RETURN 0;  -- Person does not exist
END