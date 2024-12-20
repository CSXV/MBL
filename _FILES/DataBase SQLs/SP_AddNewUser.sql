USE [MyBookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewUser]    Script Date: 12-05-1446 14:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_AddNewUser]
    @UserName NVARCHAR(10),
    @Password NVARCHAR(64),
    @IsActive BIT,
	@UserID INT OUT
AS
BEGIN
    INSERT INTO Users (UserName, Password, IsActive)
    VALUES (@UserName, @Password, @IsActive);

	SET @UserID = SCOPE_IDENTITY();
END;
