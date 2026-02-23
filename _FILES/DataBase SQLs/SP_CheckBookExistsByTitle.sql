CREATE PROCEDURE SP_CheckBookExistsByTitle
@Title INT AS BEGIN
    IF EXISTS(SELECT * FROM Books WHERE Title = @Title)
        RETURN 1;  -- exists
	ELSE
        RETURN 0;  -- does not exist
END