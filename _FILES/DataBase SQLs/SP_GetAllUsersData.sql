CREATE PROCEDURE SP_GetAllUsersData AS BEGIN
    SELECT
        u.UserID,
        u.UserName AS Name,
        u.IsActive AS IsActive,
		COUNT(r.UserID) as Records
    FROM  Users u
	LEFT JOIN UsersRecords r ON u.UserID = r.UserID
	GROUP BY u.UserID, u.UserName, u.IsActive
    ORDER BY Name;
END;