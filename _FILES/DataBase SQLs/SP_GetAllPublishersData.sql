CREATE PROCEDURE GetAllPublishersData
AS
BEGIN
    SELECT 
        p.PublisherID,
        p.Name AS PublisherName,
        pi.Email AS PublisherEmail,
        pi.Phone AS PublisherPhone,
        pi.Website AS PublisherWebsite

    FROM 
        Publishers p
    LEFT JOIN 
        ContactInfo pi ON p.ContactInfoID = pi.ContactInfoID -- Join with ContactInfo for publisher's contact details

    ORDER BY 
        p.Name;  -- Sorting publishers by their name
END;
