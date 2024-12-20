using DVLD_AccessLayerSettings;
using MyBookLibrary_BusinessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyBookLibrary_AccessLayer {
  public class PublisherAccess {
    public static int AddPublisher(string Name, string Phone, string Email, string Website) {
      int PublisherID = -1;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_AddNewPublisher", connection);
      command.CommandType = CommandType.StoredProcedure;

      SqlParameter outputIdParm = new SqlParameter("@PublisherID", SqlDbType.Int) {
        Direction = ParameterDirection.Output,
      };

      command.Parameters.Add(outputIdParm);
      command.Parameters.AddWithValue("@PublisherName", Name);
      command.Parameters.AddWithValue("@Phone", Phone);
      command.Parameters.AddWithValue("@Email", Email);
      command.Parameters.AddWithValue("@Website", Website);

      try {
        connection.Open();
        command.ExecuteNonQuery();

        PublisherID = (int)command.Parameters["@PublisherID"].Value;
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return PublisherID;
    }

    public static bool UpdatePublisher(int PublisherID, string Name, string Phone, string Email, string Website) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_UpdatePublisher", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@Name", Name);
      command.Parameters.AddWithValue("@Phone", Phone);
      command.Parameters.AddWithValue("@Email", Email);
      command.Parameters.AddWithValue("@Website", Website);
      command.Parameters.AddWithValue("@PublisherID", PublisherID);

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

    public static bool GetPublisherInfoByID(int PublisherID, ref string Name, ref string Phone, ref string Email, ref string Website) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetPublisherInfoByID", connection);

      command.Parameters.AddWithValue("@PublisherID", PublisherID);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          Name = (string)reader["Name"];
          Phone = (string)reader["Phone"];
          Email = (string)reader["Email"];
          Website = (string)reader["Website"];

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

    public static bool GetPublisherInfoByName(ref int PublisherID, string Name, ref string Phone, ref string Email, ref string Website) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetPublisherInfoByName", connection);

      command.Parameters.AddWithValue("@Name", Name);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        using(SqlDataReader reader = command.ExecuteReader()) {
          while(reader.Read()) {
            IsFound = true;

            PublisherID = (int)reader["PublisherID"];
            Phone = (string)reader["Phone"];
            Email = (string)reader["Email"];
            Website = (string)reader["Website"];
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

    public static bool IsPublisherExistByID(int ID) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckPublisherExistsByID", connection);
      command.CommandType = CommandType.StoredProcedure;
      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@PublisherID", (object)ID ?? DBNull.Value);
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

    public static DataTable GetAllPublishersData() {
      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlDataAdapter command = new SqlDataAdapter("SP_GetAllPublishersData", connection);

      try {
        connection.Open();
        command.Fill(dataTable);

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return dataTable;
    }

    public static bool DeletePublisher(int PublisherID) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_DeletePublisher", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@PublisherID", PublisherID);

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
