CREATE PROCEDURE SP_GetBookInfoByID
    @BookID INT  -- The input parameter to specify the BookID
AS BEGIN
    SET NOCOUNT ON;

    -- Select book details by BookID
    SELECT
        b.BookID,
        b.Title,
        b.ISBN,
        b.Edition,
        b.PublicationDate,
        b.Language,
        b.Cover,
        b.Pages,
        b.Description,
        b.Series,
        p.PublisherID, -- Assuming the Publishers table has a column PublisherName
        a.AuthorID,    -- Assuming the Authors table has a column AuthorName
        t.TopicName,   -- Assuming the Topics table has a column TopicName
        STRING_AGG(tag.TagName, ', ') AS Tags  -- Concatenate all associated tags for the book
    FROM
        Books b
    LEFT JOIN
        Publishers p ON b.PublisherID = p.PublisherID
    LEFT JOIN
        Authors a ON b.AuthorID = a.AuthorID
    LEFT JOIN
        BookTopics bt ON b.BookID = bt.BookID
    LEFT JOIN
        Topics t ON bt.TopicID = t.TopicID
    LEFT JOIN
        BookTags btg ON b.BookID = btg.BookID
    LEFT JOIN
        Tags tag ON btg.TagID = tag.TagID
    WHERE
        b.BookID = @BookID  -- Filter by the specified BookID
    GROUP BY
        b.BookID, b.Title, b.ISBN, b.Edition, b.PublicationDate,
		b.Language, b.Cover, b.Pages, b.Description, b.Series,
		p.PublisherID, a.AuthorID, t.TopicName
    ORDER BY
        b.Title;  -- Optional, you can change the ordering as per your requirement
END;
