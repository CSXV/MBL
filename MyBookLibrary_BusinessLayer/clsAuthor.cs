using MyBookLibrary_AccessLayer;
using System.Data;

namespace MyBookLibrary_BusinessLayer {
  public class clsAuthor {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }

    public string FullName() {
      return FirstName + " " + LastName;
    }

    public clsAuthor() {
      this.ID = -1;
      this.FirstName = "";
      this.LastName = "";
      this.Phone = "";
      this.Email = "";
      this.Website = "";

      _Mode = enMode.AddNew;
    }

    public clsAuthor(int iD, string firstName, string lastName, string phone, string email, string website) {
      this.ID = iD;
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Phone = phone;
      this.Email = email;
      this.Website = website;

      _Mode = enMode.Update;
    }

    private bool _AddNewAuthor() {
      this.ID =
          AuthorAccess.AddAuthor(
      this.FirstName, this.LastName, this.Phone, this.Email, this.Website);

      return (this.ID != -1);
    }

    private bool _UpdateAuthor() {
      return AuthorAccess.UpdateAuthor(this.ID, this.FirstName, this.LastName, this.Phone, this.Email, this.Website);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewAuthor()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateAuthor();
      }

      return false;
    }

    public static clsAuthor Find(int AuthorID) {
      string FirstName = "";
      string LastName = "";
      string Phone = "";
      string Email = "";
      string Website = "";

      if(AuthorAccess.GetAuthorInfoByID(AuthorID, ref FirstName, ref LastName, ref Phone, ref Email, ref Website)) {
        return new clsAuthor(AuthorID, FirstName, LastName, Phone, Email, Website);
      } else {
        return null;
      }
    }

    public static clsAuthor Find(string FirstName, string LastName) {
      int AuthorID = -1;
      string Phone = "";
      string Email = "";
      string Website = "";

      if(AuthorAccess.GetAuthorInfoByName(ref AuthorID, FirstName, LastName, ref Phone, ref Email, ref Website)) {
        return new clsAuthor(AuthorID, FirstName, LastName, Phone, Email, Website);
      } else {
        return null;
      }
    }

    public static bool IsAuthorExist(int ID) {
      return AuthorAccess.IsAuthorExistByID(ID);
    }

    public static DataTable GetAllAuthors() {
      return AuthorAccess.GetAllAuthorsData();
    }

    public static bool DeleteAuthor(int AurhorID) {
      return AuthorAccess.DeleteAuthor(AurhorID);
    }
  }
}
