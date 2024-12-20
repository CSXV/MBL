CREATE PROCEDURE SP_GetAuthorInfoByID
    @AuthorID INT AS BEGIN
	SELECT
        a.AuthorID,
        a.FirstName,
        a.LastName,
        c.Phone,
        c.Website,
        c.Email
    FROM
        Authors a
    LEFT JOIN
        ContactInfo c ON a.ContactInfoID = c.ContactInfoID
    WHERE 
        a.AuthorID = @AuthorID;
END;