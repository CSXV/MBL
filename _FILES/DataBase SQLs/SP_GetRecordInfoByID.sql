CREATE PROCEDURE SP_GetRecordInfoByID
    @RecordID INT AS BEGIN
	SELECT
        r.UserID,
        r.BookID,
        r.State,
		r.Rating,
		r.Difficulty,
		r.ReadingDuration,
		r.FinishDate,
		r.Comments

    FROM
        UsersRecords r
    WHERE 
        r.UserRecordID = @RecordID;
END;