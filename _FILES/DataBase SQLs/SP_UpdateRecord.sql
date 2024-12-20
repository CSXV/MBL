ALTER PROCEDURE SP_UpdateRecord
    @RecordID INT,
    @UserID INT = NULL,
    @BookID INT = NULL,
    @State TINYINT = NULL,
	@Difficulty TINYINT = NULL,
	@Rating TINYINT = NULL,
	@ReadingDuration INT = NULL,
	@FinishDate DATE = NULL,
	@Comments NVARCHAR(MAX) = NULL

AS BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        UPDATE UsersRecords
        SET 
            UserID = ISNULL(@UserID, UserID),
            BookID = ISNULL(@BookID, BookID),
			@State = ISNULL(@State, State),
			@Difficulty = ISNULL(@Difficulty, Difficulty),
			@Rating = ISNULL(@Rating, Rating),
			@ReadingDuration = ISNULL(@ReadingDuration, ReadingDuration),
			@FinishDate = ISNULL(@FinishDate, FinishDate),
			@Comments = ISNULL(@Comments, Comments)

        WHERE UserRecordID = @RecordID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;
