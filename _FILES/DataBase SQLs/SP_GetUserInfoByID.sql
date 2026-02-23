create procedure SP_GetUserInfoByID
	@UserID int
as begin
	select * from Users where UserID = @UserID;
end