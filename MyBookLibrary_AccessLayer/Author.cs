using DVLD_AccessLayerSettings;
using MyBookLibrary_BusinessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyBookLibrary_AccessLayer {
  public class AuthorAccess {
    public static int AddAuthor(string FirstName, string LastName, string Phone, string Email, string Website) {
      int AuthorID = -1;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_AddNewAuthor", connection);
      command.CommandType = CommandType.StoredProcedure;

      SqlParameter outputIdParm = new SqlParameter("@AuthorID", SqlDbType.Int) {
        Direction = ParameterDirection.Output,
      };

      command.Parameters.Add(outputIdParm);
      command.Parameters.AddWithValue("@FirstName", FirstName);
      command.Parameters.AddWithValue("@LastName", LastName);
      command.Parameters.AddWithValue("@Phone", Phone);
      command.Parameters.AddWithValue("@Email", Email);
      command.Parameters.AddWithValue("@Website", Website);

      try {
        connection.Open();
        command.ExecuteNonQuery();

        AuthorID = (int)command.Parameters["@AuthorID"].Value;
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return AuthorID;
    }

    public static bool UpdateAuthor(int AuthorID, string FirstName, string LastName, string Phone, string Email, string Website) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_UpdateAuthor", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@FirstName", FirstName);
      command.Parameters.AddWithValue("@LastName", LastName);
      command.Parameters.AddWithValue("@Phone", Phone);
      command.Parameters.AddWithValue("@Email", Email);
      command.Parameters.AddWithValue("@Website", Website);
      command.Parameters.AddWithValue("@AuthorID", AuthorID);

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

    public static bool GetAuthorInfoByID(int AuthorID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string Website) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetAuthorInfoByID", connection);

      command.Parameters.AddWithValue("@AuthorID", AuthorID);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          FirstName = (string)reader["FirstName"];
          LastName = (string)reader["LastName"];
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

    public static bool GetAuthorInfoByName(ref int AuthorID, string FirstName, string LastName, ref string Phone, ref string Email, ref string Website) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetAuthorInfoByName", connection);

      command.Parameters.AddWithValue("@FirstName", FirstName);
      command.Parameters.AddWithValue("@LastName", LastName);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        using(SqlDataReader reader = command.ExecuteReader()) {
          while(reader.Read()) {
            IsFound = true;

            AuthorID = (int)reader["AuthorID"];
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

    public static bool IsAuthorExistByID(int ID) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckAuthorExistsByID", connection);
      command.CommandType = CommandType.StoredProcedure;
      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@AuthorID", (object)ID ?? DBNull.Value);
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

    public static DataTable GetAllAuthorsData() {
      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlDataAdapter command = new SqlDataAdapter("SP_GetAllAuthorsData", connection);

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

    public static bool DeleteAuthor(int AuthorID) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_DeleteAuthor", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@AuthorID", AuthorID);

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
