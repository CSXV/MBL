using DVLD_AccessLayerSettings;
using MyBookLibrary_BusinessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyBookLibrary_AccessLayer {
  public class RecordAccess {
    public static int AddRecord(int UserID, int BookID, byte State, byte Difficulty, byte Rating, int ReadingDuration, DateTime FinishDate, string Comments) {
      int RecordID = -1;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_AddUserRecord", connection);
      command.CommandType = CommandType.StoredProcedure;

      SqlParameter outputIdParm = new SqlParameter("@RecordID", SqlDbType.Int) {
        Direction = ParameterDirection.Output,
      };

      command.Parameters.Add(outputIdParm);
      command.Parameters.AddWithValue("@UserID", UserID);
      command.Parameters.AddWithValue("@BookID", BookID);
      command.Parameters.AddWithValue("@State", (object)State ?? DBNull.Value);
      command.Parameters.AddWithValue("@Difficulty", (object)Difficulty ?? DBNull.Value);
      command.Parameters.AddWithValue("@Rating", (object)Rating ?? DBNull.Value);
      command.Parameters.AddWithValue("@ReadingDuration", (object)ReadingDuration ?? DBNull.Value);
      command.Parameters.AddWithValue("@FinishDate", (Object)FinishDate ?? DBNull.Value);
      command.Parameters.AddWithValue("@Comments", (object)Comments ?? DBNull.Value);

      try {
        connection.Open();
        command.ExecuteNonQuery();

        RecordID = (int)command.Parameters["@RecordID"].Value;
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return RecordID;
    }

    public static bool UpdateRecord(int RecordID, int UserID, int BookID, byte State, byte Difficulty, byte Rating, int ReadingDuration, DateTime FinishDate, string Comments) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_UpdateRecord", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@RecordID", RecordID);
      command.Parameters.AddWithValue("@UserID", UserID);
      command.Parameters.AddWithValue("@BookID", BookID);
      command.Parameters.AddWithValue("@State", (object)State ?? DBNull.Value);
      command.Parameters.AddWithValue("@Difficulty", (object)Difficulty ?? DBNull.Value);
      command.Parameters.AddWithValue("@Rating", (object)Rating ?? DBNull.Value);
      command.Parameters.AddWithValue("@ReadingDuration", (object)ReadingDuration ?? DBNull.Value);
      command.Parameters.AddWithValue("@FinishDate", (Object)FinishDate ?? DBNull.Value);
      command.Parameters.AddWithValue("@Comments", (object)Comments ?? DBNull.Value);

      try {
        connection.Open();
        RowsAffected = command.ExecuteNonQuery();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        return false;
      } finally {
        connection.Close();
      }

      return (RowsAffected > 0);
    }

    public static bool GetRecordInfoByID(int RecordID, ref int UserID, ref int BookID, ref byte State, ref byte Difficulty, ref byte Rating, ref int ReadingDuration, ref DateTime FinishDate, ref string Comments) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetRecordInfoByID", connection);

      command.Parameters.AddWithValue("@RecordID", RecordID);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          UserID = (int)reader["UserID"];
          BookID = (int)reader["BookID"];
          State = (byte)reader["State"];
          Difficulty = (byte)reader["Difficulty"];
          Rating = (byte)reader["Rating"];
          ReadingDuration = (int)reader["ReadingDuration"];
          FinishDate = (DateTime)reader["FinishDate"];
          Comments = (string)reader["Comments"];

        } else {
          IsFound = false;
        }

        reader.Close();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;
      } finally {
        connection.Close();
      }

      return IsFound;
    }

    public static bool IsRecordExistByID(int ID) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckRecordExistsByID", connection);
      command.CommandType = CommandType.StoredProcedure;
      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@RecordID", (object)ID ?? DBNull.Value);
      command.Parameters.Add(returnParameter);

      try {
        connection.Open();
        command.ExecuteNonQuery();

        IsFound = (int)returnParameter.Value == 1;

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;

      } finally {
        connection.Close();
      }

      return IsFound;
    }

    public static DataTable GetAllRecordsData(int UserID) {
      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("[SP_GetAllUsersRecordsData]", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)).Value = UserID;

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();
        dataTable.Load(reader);

        reader.Close();
      } catch(Exception ex) {
        Console.WriteLine("Error: " + ex.Message);
      } finally {
        connection.Close();
      }

      return dataTable;
    }

    public static bool DeleteRecord(int RecordID) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_DeleteRecord", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@RecordID", RecordID);

      try {
        connection.Open();
        RowsAffected = command.ExecuteNonQuery();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        return false;
      } finally {
        connection.Close();
      }

      return (RowsAffected > 0);

    }
  }
}
