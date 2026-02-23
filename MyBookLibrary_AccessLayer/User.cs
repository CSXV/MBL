using DVLD_AccessLayerSettings;
using MyBookLibrary_BusinessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyBookLibrary_AccessLayer {
  public class UserAccess {
    public static int AddUser(string UserName, string Password, bool IsActive) {
      int UserID = -1;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_AddNewUser", connection);
      command.CommandType = CommandType.StoredProcedure;

      SqlParameter outputIdParm = new SqlParameter("@UserID", SqlDbType.Int) {
        Direction = ParameterDirection.Output,
      };

      command.Parameters.Add(outputIdParm);
      command.Parameters.AddWithValue("@UserName", UserName);
      command.Parameters.AddWithValue("@Password", Password);
      command.Parameters.AddWithValue("@IsActive", IsActive);

      try {
        connection.Open();
        command.ExecuteNonQuery();

        UserID = (int)command.Parameters["@UserID"].Value;
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return UserID;
    }

    public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_UpdateUser", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@UserName", UserName);
      command.Parameters.AddWithValue("@Password", Password);
      command.Parameters.AddWithValue("@IsActive", IsActive);
      command.Parameters.AddWithValue("@UserID", UserID);

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

    public static bool GetUserInfoByID(int UserID, ref string UserName, ref string Password, ref bool IsActive) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetUserInfoByID", connection);

      command.Parameters.AddWithValue("@UserID", UserID);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          UserName = (string)reader["UserName"];
          Password = (string)reader["Password"];
          IsActive = (bool)reader["IsActive"];

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

    public static bool GetUserInfoByName(ref int UserID, string UserName, ref string Password, ref bool IsActive) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetUserInfoByName", connection);

      command.Parameters.AddWithValue("@UserName", UserName);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        using(SqlDataReader reader = command.ExecuteReader()) {
          while(reader.Read()) {
            IsFound = true;

            UserID = (int)reader["UserID"];
            Password = (string)reader["Password"];
            IsActive = (bool)reader["IsActive"];
          }
        }

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;
      } finally {
        connection.Close();
      }

      return IsFound;
    }

    public static bool IsUserExistByID(int ID) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckUserExistsByID", connection);
      command.CommandType = CommandType.StoredProcedure;
      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@UserID", (object)ID ?? DBNull.Value);
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

    public static bool IsUserExistByName(string UserName) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckUserExistsByName", connection);

      command.CommandType = CommandType.StoredProcedure;

      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@UserName", (object)UserName ?? DBNull.Value);
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

    public static DataTable GetAllUsersData() {
      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlDataAdapter command = new SqlDataAdapter("SP_GetAllUsersData", connection);

      try {
        connection.Open();
        command.Fill(dataTable);

      } catch(Exception ex) {
        Console.WriteLine("Error: " + ex.Message);
      } finally {
        connection.Close();
      }

      return dataTable;
    }

    public static bool DeleteUser(int UserID) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_DeleteUser", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@UserID", UserID);

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
