USE [MyBookLibrary]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllAuthorsData]    Script Date: 12-05-1446 15:10:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_GetAllAuthorsData]
AS
BEGIN
    SELECT 
        a.AuthorID,
        a.FirstName AS FirstName,
        a.LastName AS LastName,
        ai.Email AS Email,
        ai.Phone AS Phone,
        ai.Website AS Website

    FROM 
        Authors a
    LEFT JOIN 
        ContactInfo ai ON a.ContactInfoID = ai.ContactInfoID -- Join with ContactInfo for author's contact details

    ORDER BY 
        a.LastName, a.FirstName;  -- Sorting authors by their last and first names
END;
