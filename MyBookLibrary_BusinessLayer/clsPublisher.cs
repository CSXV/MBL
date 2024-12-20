using MyBookLibrary_AccessLayer;
using System.Data;

namespace MyBookLibrary_BusinessLayer {
  public class clsPublisher {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int ID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }

    public clsPublisher() {
      this.ID = -1;
      this.Name = "";
      this.Phone = "";
      this.Email = "";
      this.Website = "";

      _Mode = enMode.AddNew;
    }

    public clsPublisher(int iD, string name, string phone, string email, string website) {
      ID = iD;
      Name = name;
      Phone = phone;
      Email = email;
      Website = website;

      _Mode = enMode.Update;
    }

    private bool _AddNewPublisher() {
      this.ID =
          PublisherAccess.AddPublisher(
      this.Name, Phone, Email, Website);

      return (this.ID != -1);
    }

    private bool _UpdatePublisher() {
      return PublisherAccess.UpdatePublisher(this.ID, this.Name, Phone, Email, Website);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewPublisher()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdatePublisher();
      }

      return false;
    }

    public static clsPublisher Find(int ID) {
      string Name = "";
      string Phone = "";
      string Email = "";
      string Website = "";

      if(PublisherAccess.GetPublisherInfoByID(ID, ref Name, ref Phone, ref Email, ref Website)) {
        return new clsPublisher(ID, Name, Phone, Email, Website);
      } else {
        return null;
      }
    }

    public static clsPublisher Find(string Name) {
      int ID = -1;
      string Phone = "";
      string Email = "";
      string Website = "";

      if(PublisherAccess.GetPublisherInfoByName(ref ID, Name, ref Phone, ref Email, ref Website)) {

        return new clsPublisher(ID, Name, Phone, Email, Website);
      } else {
        return null;
      }
    }

    public static bool IsPublisherExist(int ID) {
      return PublisherAccess.IsPublisherExistByID(ID);
    }

    public static DataTable GetAllPublishers() {
      return PublisherAccess.GetAllPublishersData();
    }

    public static bool DeletePublisher(int PublisherID) {
      return PublisherAccess.DeletePublisher(PublisherID);
    }
  }
}
