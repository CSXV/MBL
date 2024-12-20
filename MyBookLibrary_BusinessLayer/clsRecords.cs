using MyBookLibrary_AccessLayer;
using System;
using System.Data;

namespace MyBookLibrary_BusinessLayer {
  public class clsRecords {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int RecordID { get; set; }
    public int UserID { get; set; }
    public int BookID { get; set; }
    public byte State { get; set; }
    public byte Difficulty { get; set; }
    public byte Rating { get; set; }
    public int ReadingDuration { get; set; }
    public DateTime FinishDate { get; set; }
    public string Comments { get; set; }

    public clsUser UserInfo { get; set; }
    public clsBook BookInfo { get; set; }

    public clsRecords() {
      this.RecordID = -1;
      this.UserID = -1;
      this.BookID = -1;
      this.State = 0;
      this.Difficulty = 0;
      this.Rating = 0;
      this.ReadingDuration = 0;
      this.FinishDate = DateTime.Now;
      this.Comments = "";

      _Mode = enMode.AddNew;
    }

    public clsRecords(int recordID, int userID, int bookID, byte state, byte difficulty, byte rating, int readingDuration, DateTime finishDate, string comments) {
      this.RecordID = recordID;
      this.UserID = userID;
      this.BookID = bookID;
      this.State = state;
      this.Difficulty = difficulty;
      this.Rating = rating;
      this.ReadingDuration = readingDuration;
      this.FinishDate = finishDate;
      this.Comments = comments;

      this.UserInfo = clsUser.Find(UserID);
      this.BookInfo = clsBook.Find(BookID);

      _Mode = enMode.Update;
    }

    private bool _AddNewRecord() {
      this.RecordID =
          RecordAccess.AddRecord(
      this.UserID, this.BookID, this.State, this.Difficulty, this.Rating, this.ReadingDuration, this.FinishDate, this.Comments);

      return (this.RecordID != -1);
    }

    private bool _UpdateRecord() {
      return RecordAccess.UpdateRecord(this.RecordID, this.UserID, this.BookID, this.State, this.Difficulty, this.Rating, this.ReadingDuration, this.FinishDate, this.Comments);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewRecord()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateRecord();
      }

      return false;
    }

    public static clsRecords Find(int RecordID) {
      int UserID = -1;
      int BookID = -1;
      byte State = 0;
      byte Difficulty = 0;
      byte Rating = 0;
      int ReadingDuration = 0;
      DateTime FinishDate = DateTime.Now;
      string Comments = "";

      if(RecordAccess.GetRecordInfoByID(RecordID, ref UserID, ref BookID, ref State, ref Difficulty, ref Rating, ref ReadingDuration, ref FinishDate, ref Comments)) {
        return new clsRecords(RecordID, UserID, BookID, State, Difficulty, Rating, ReadingDuration, FinishDate, Comments);
      } else {
        return null;
      }
    }

    public static bool IsRecordExist(int ID) {
      return RecordAccess.IsRecordExistByID(ID);
    }

    public static DataTable GetAllRecordsRecords(int UserID) {
      return RecordAccess.GetAllRecordsData(UserID);
    }

    public static bool DeleteARecord(int RecordID) {
      return RecordAccess.DeleteRecord(RecordID);
    }
  }
}
