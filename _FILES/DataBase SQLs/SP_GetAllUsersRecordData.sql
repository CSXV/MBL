CREATE PROCEDURE SP_GetAllUsersRecordsData
AS
BEGIN
    SELECT 
        ur.UserRecordID,
        ur.BookID,
        ur.UserID,
        ur.AddedDate AS RecordAddedDate,
        ur.State,
        ur.Difficulty,
        ur.Rating,
        ur.ReadingDuration,
        ur.FinishDate,
        ur.Comments AS UserComments,

        -- User information
        u.UserName AS UserName,
        u.IsActive AS UserStatus,

        -- Book information
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
        pi.Email AS PublisherEmail,
        pi.Phone AS PublisherPhone,
        pi.Website AS PublisherWebsite,

        -- Author information
        a.FirstName AS AuthorFirstName,
        a.LastName AS AuthorLastName,
        ai.Email AS AuthorEmail,
        ai.Phone AS AuthorPhone,
        ai.Website AS AuthorWebsite

    FROM 
        UsersRecords ur
    LEFT JOIN 
        Users u ON ur.UserID = u.UserID

    LEFT JOIN 
        Books b ON ur.BookID = b.BookID
    LEFT JOIN 
        Publishers p ON b.PublisherID = p.PublisherID
    LEFT JOIN 
        ContactInfo pi ON p.ContactInfoID = pi.ContactInfoID -- Publisher contact info

    LEFT JOIN 
        Authors a ON b.AuthorID = a.AuthorID
    LEFT JOIN 
        ContactInfo ai ON a.ContactInfoID = ai.ContactInfoID -- Author contact info

    ORDER BY 
        ur.AddedDate DESC; -- Sort by the most recently added user record
END;
