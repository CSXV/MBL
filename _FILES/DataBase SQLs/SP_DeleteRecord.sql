CREATE PROCEDURE SP_DeleteRecord
@RecordID INT
AS BEGIN
	DELETE FROM UsersRecords WHERE UserRecordID = @RecordID
END