CREATE PROCEDURE GetAllBooksData
AS
BEGIN
    -- Select all relevant data about books, authors, publishers, tags, and topics
    SELECT 
        b.BookID,
        b.Title AS BookTitle,
        b.ISBN,
        b.Edition,
        b.PublicationDate,
        b.Language,
        b.Cover,
        b.Pages,
        b.Description AS BookDescription,
        b.Series,
        b.AddedDate AS BookAddedDate,

        -- Publisher information
        p.Name AS PublisherName,
        p.ContactInfoID AS PublisherContactInfoID,
        pi.Email AS PublisherEmail,
        pi.Phone AS PublisherPhone,
        pi.Website AS PublisherWebsite,

        -- Author information
        a.FirstName AS AuthorFirstName,
        a.LastName AS AuthorLastName,
        a.ContactInfoID AS AuthorContactInfoID,
        ai.Email AS AuthorEmail,
        ai.Phone AS AuthorPhone,
        ai.Website AS AuthorWebsite,

        -- Tags (can be multiple, comma-separated)
        STUFF((SELECT ', ' + t.TagName
               FROM Tags t
               JOIN BookTags bt ON t.TagID = bt.TagID
               WHERE bt.BookID = b.BookID
               FOR XML PATH('')), 1, 2, '') AS Tags,

        -- Topics (can be multiple, comma-separated)
        STUFF((SELECT ', ' + t.TopicName
               FROM Topics t
               JOIN BookTopics bt ON t.TopicID = bt.TopicID
               WHERE bt.BookID = b.BookID
               FOR XML PATH('')), 1, 2, '') AS Topics

    FROM 
        Books b
    LEFT JOIN 
        Publishers p ON b.PublisherID = p.PublisherID
    LEFT JOIN 
        ContactInfo pi ON p.ContactInfoID = pi.ContactInfoID -- Publisher contact info

    LEFT JOIN 
        Authors a ON b.AuthorID = a.AuthorID
    LEFT JOIN 
        ContactInfo ai ON a.ContactInfoID = ai.ContactInfoID -- Author contact info

    ORDER BY 
        b.Title ASC; -- Sort by the title name
END;
