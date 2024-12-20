CREATE PROCEDURE SP_GetPublisherInfoByID
    @PublisherID INT AS BEGIN
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
        a.PublisherID = @PublisherID;
END;