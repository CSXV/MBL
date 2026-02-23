using MyBookLibrary_AccessLayer;
using System;
using System.Data;

namespace MyBookLibrary_BusinessLayer {
  public class clsBook {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int ID { get; set; }
    public string Tags { get; set; }
    public string Topic { get; set; }
    public int PublisherID { get; set; }
    public int AuthorID { get; set; }

    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Language { get; set; }
    public string Cover { get; set; }
    public string Description { get; set; }
    public string Series { get; set; }

    public byte Edition { get; set; }
    public int Pages { get; set; }
    public DateTime PublicationDate { get; set; }

    public clsAuthor AuthorInfo;
    public clsPublisher PublisherInfo;

    public clsBook() {
      this.ID = -1;
      this.Tags = "";
      this.Topic = "";
      this.PublisherID = -1;
      this.AuthorID = -1;

      this.Title = "";
      this.ISBN = "";
      this.Language = "";
      this.Cover = "";
      this.Description = "";
      this.Series = "";

      this.Pages = -1;
      this.Edition = 1;
      this.PublicationDate = DateTime.Now;

      _Mode = enMode.AddNew;
    }

    public clsBook(int ID, string Tags, string Topic, int publisherID, int authorID, string title, string isbn, string language, string cover, string description, string series, int pages, byte edition, DateTime pubDate) {
      this.ID = ID;
      this.Tags = Tags;
      this.Topic = Topic;
      this.PublisherID = publisherID;
      this.AuthorID = authorID;

      this.Title = title;
      this.ISBN = isbn;
      this.Language = language;
      this.Cover = cover;
      this.Description = description;
      this.Series = series;

      this.Pages = pages;
      this.Edition = edition;
      this.PublicationDate = pubDate;

      this.AuthorInfo = clsAuthor.Find(authorID);
      this.PublisherInfo = clsPublisher.Find(publisherID);

      _Mode = enMode.Update;
    }

    private bool _AddNewBook() {
      this.ID =
          BookAccess.AddBook(
      this.Tags, this.Topic, this.PublisherID, this.AuthorID, this.Title, this.ISBN, this.Language, this.Cover, this.Description, this.Series, this.Edition, this.Pages, this.PublicationDate);

      return (this.ID != -1);
    }

    //int ID , int TagID , int TopicID , int PublisherID , int AuthorID , string Title , string ISBN , string Language , string Cover , string Description , string Series , byte Edition, int Pages , DateTime PublicationDate

    private bool _UpdateBook() {
      return BookAccess.UpdateBook(
      this.ID, this.Tags, this.Topic, this.PublisherID, this.AuthorID, this.Title, this.ISBN, this.Language, this.Cover, this.Description, this.Series, this.Edition, this.Pages, this.PublicationDate);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewBook()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateBook();
      }

      return false;
    }

    public static clsBook Find(int BookID) {
      int PublisherID = -1;
      int AuthorID = -1;

      string Tags = "";
      string Topic = "";
      string Title = "";
      string ISBN = "";
      string Language = "";
      string Cover = "";
      string Description = "";
      string Series = "";

      int Pages = -1;
      byte Edition = 1;
      DateTime PublicationDate = DateTime.Now;

      if(BookAccess.GetBookInfoByID(BookID, ref Tags, ref Topic, ref PublisherID, ref AuthorID, ref Title, ref ISBN, ref Language, ref Cover, ref Description, ref Series, ref Edition, ref Pages, ref PublicationDate
)) {
        return new clsBook(BookID, Tags, Topic, PublisherID, AuthorID, Title, ISBN, Language, Cover, Description, Series, Pages, Edition, PublicationDate);
      } else {
        return null;
      }
    }

    /*public static clsBook Find(string Title) {
      int ID = -1;
      int PublisherID = -1;
      int AuthorID = -1;

      string Tags = "";
      string Topic = "";
      string ISBN = "";
      string Language = "";
      string Cover = "";
      string Description = "";
      string Series = "";

      int Pages = -1;
      byte Edition = -1;
      DateTime PublicationDate = DateTime.Now;

      if(BookAccess.GetAllBookInfoByTitle(ref ID, ref Tags, ref Topic, ref PublisherID, ref AuthorID, Title, ref ISBN, ref Language, ref Cover, ref Description, ref Series, ref Edition, ref Pages, ref PublicationDate
)) {
        return new clsBook(ID, Tags, Topic, PublisherID, AuthorID, Title, ISBN, Language, Cover, Description, Series, Pages, Edition, PublicationDate);
      } else {
        return null;
      }
    }*/

    public static bool IsBookExist(int ID) {
      return BookAccess.IsBookExistByID(ID);
    }

    public static bool IsBookExist(string Title) {
      return BookAccess.IsBookExistByTitle(Title);
    }

    public static DataTable GetAllBooks() {
      return BookAccess.GetAllBooksData();
    }

    public static bool DeleteABook(int BookID) {
      return BookAccess.DeleteBook(BookID);
    }
  }
}
