using MyBookLibrary_AccessLayer;
using System.Data;

namespace MyBookLibrary_BusinessLayer {
  public class clsUser {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int ID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }

    public clsUser() {
      this.ID = -1;
      this.UserName = "";
      this.Password = "";
      this.IsActive = false;

      _Mode = enMode.AddNew;
    }

    public clsUser(int ID, string UserName, string Password, bool IsActive) {
      this.ID = ID;
      this.UserName = UserName;
      this.Password = Password;
      this.IsActive = IsActive;

      //this.AuthorInfo = clsAuthor;
      //this.PublisherInfo = clsPublisher;

      _Mode = enMode.Update;
    }

    private bool _AddNewUser() {
      this.ID =
          UserAccess.AddUser(
      this.UserName, this.Password, this.IsActive);

      return (this.ID != -1);
    }

    //int ID , int TagID , int TopicID , int PublisherID , int AuthorID , string Title , string ISBN , string Language , string Cover , string Description , string Series , int Edition, int Pages , DateTime PublicationDate

    private bool _UpdateUser() {
      return UserAccess.UpdateUser(
      this.ID, this.UserName, this.Password, this.IsActive);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewUser()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateUser();
      }

      return false;
    }

    public static clsUser Find(int UserID) {
      string UserName = "";
      string Password = "";
      bool IsActive = false;

      if(UserAccess.GetUserInfoByID(UserID, ref UserName, ref Password, ref IsActive)) {
        return new clsUser(UserID, UserName, Password, IsActive);
      } else {
        return null;
      }
    }

    public static clsUser Find(string UserName) {
      int UserID = -1;
      string Password = "";
      bool IsActive = false;

      if(UserAccess.GetUserInfoByName(ref UserID, UserName, ref Password, ref IsActive)) {
        return new clsUser(UserID, UserName, Password, IsActive);
      } else {
        return null;
      }
    }

    public static bool IsUserExist(int ID) {
      return UserAccess.IsUserExistByID(ID);
    }

    public static bool IsUserExist(string Name) {
      return UserAccess.IsUserExistByName(Name);
    }

    public static DataTable GetAllUsers() {
      return UserAccess.GetAllUsersData();
    }

    public static bool DeleteUser(int UserID) {
      return UserAccess.DeleteUser(UserID);
    }
  }
}
