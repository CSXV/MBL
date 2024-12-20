CREATE PROCEDURE SP_GetPublisherInfoByName
    @Name INT AS BEGIN
	SELECT
        a.PublisherID,
        a.Name,
        c.Phone,
        c.Website,
        c.Email
    FROM
        Publishers a
    LEFT JOIN
        ContactInfo c ON a.ContactInfoID = c.ContactInfoID
    WHERE 
        a.Name = @Name;
END;