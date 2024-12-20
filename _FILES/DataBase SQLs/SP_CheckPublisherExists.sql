CREATE PROCEDURE SP_CheckPublisherExists
@PublisherID INT AS BEGIN
    IF EXISTS(SELECT * FROM Publishers WHERE PublisherID = @PublisherID)
        RETURN 1;  -- Person exists
	ELSE
        RETURN 0;  -- Person does not exist
END