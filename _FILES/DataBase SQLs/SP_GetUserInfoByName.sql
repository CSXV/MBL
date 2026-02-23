create procedure SP_GetUserInfoByName
	@UserName int
as begin
	select * from Users where UserName = @UserName;
end