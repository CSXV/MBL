using DVLD_AccessLayerSettings;
using MyBookLibrary_BusinessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyBookLibrary_AccessLayer {
  public class BookAccess {
    public static int AddBook(string Tags, string Topic, int PublisherID, int AuthorID, string Title, string ISBN, string Language, string Cover, string Description, string Series, byte Edition, int Pages, DateTime PublicationDate
      ) {
      int BookID = -1;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_AddNewBook", connection);
      command.CommandType = CommandType.StoredProcedure;

      SqlParameter outputIdParm = new SqlParameter("@BookID", SqlDbType.Int) {
        Direction = ParameterDirection.Output,
      };

      command.Parameters.Add(outputIdParm);
      command.Parameters.AddWithValue("@Title", Title);
      command.Parameters.AddWithValue("@ISBN", ISBN);
      command.Parameters.AddWithValue("@Edition", Edition);
      command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
      command.Parameters.AddWithValue("@Language", Language);
      command.Parameters.AddWithValue("@Cover", (object)Cover ?? DBNull.Value);
      command.Parameters.AddWithValue("@Pages", Pages);
      command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
      command.Parameters.AddWithValue("@Series", (object)Series ?? DBNull.Value);
      command.Parameters.AddWithValue("@PublisherID", PublisherID);
      command.Parameters.AddWithValue("@AuthorID", AuthorID);
      command.Parameters.AddWithValue("@TopicName", Topic);
      command.Parameters.AddWithValue("@TagNames", Tags);

      try {
        connection.Open();
        command.ExecuteNonQuery();

        BookID = (int)command.Parameters["@BookID"].Value;
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return BookID;
    }

    public static bool UpdateBook(int ID, string Tags, string Topic, int PublisherID, int AuthorID, string Title, string ISBN, string Language, string Cover, string Description, string Series, byte Edition, int Pages, DateTime PublicationDate) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_UpdateBook", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@BookID", ID);
      command.Parameters.AddWithValue("@PublisherID", PublisherID);
      command.Parameters.AddWithValue("@AuthorID", AuthorID);
      command.Parameters.AddWithValue("@Title", Title);
      command.Parameters.AddWithValue("@ISBN", ISBN);
      command.Parameters.AddWithValue("@Edition", Edition);
      command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
      command.Parameters.AddWithValue("@Language", Language);
      command.Parameters.AddWithValue("@Pages", Pages);
      command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
      command.Parameters.AddWithValue("@Series", (object)Series ?? DBNull.Value);
      command.Parameters.AddWithValue("@TagNames", Tags);
      command.Parameters.AddWithValue("@TopicName", Topic);
      command.Parameters.AddWithValue("@Cover", (object)Cover ?? DBNull.Value);

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

    public static bool GetBookInfoByID(int ID, ref string Tags, ref string Topic, ref int PublisherID, ref int AuthorID, ref string Title, ref string ISBN, ref string Language, ref string Cover, ref string Description, ref string Series, ref byte Edition, ref int Pages, ref DateTime PublicationDate) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_GetBookInfoByID", connection);

      command.Parameters.AddWithValue("@BookID", ID);
      command.CommandType = CommandType.StoredProcedure;

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          Tags = (string)reader["Tags"];
          Topic = (string)reader["TopicName"];
          PublisherID = (int)reader["PublisherID"];
          AuthorID = (int)reader["AuthorID"];
          Title = (string)reader["Title"];
          ISBN = (string)reader["ISBN"];
          Language = (string)reader["Language"];
          Cover = (string)reader["Cover"];
          Edition = (byte)reader["Edition"];
          Pages = (int)reader["Pages"];
          PublicationDate = (DateTime)reader["PublicationDate"];

          if(reader["Description"] != DBNull.Value) {
            Description = (string)reader["Description"];
          } else {
            Description = "";
          }
          if(reader["Series"] != DBNull.Value) {
            Series = (string)reader["Series"];
          } else {
            Series = "";
          }
          if(reader["Cover"] != DBNull.Value) {
            Cover = (string)reader["Cover"];
          } else {
            Cover = "";
          }

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

    public static bool IsBookExistByID(int ID) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckBookExistsByID", connection);
      command.CommandType = CommandType.StoredProcedure;
      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@BookID", (object)ID ?? DBNull.Value);
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

    public static bool IsBookExistByTitle(string Title) {
      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_CheckBookExistsByTitle", connection);

      command.CommandType = CommandType.StoredProcedure;

      SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int) {
        Direction = ParameterDirection.ReturnValue
      };

      command.Parameters.AddWithValue("@Title", (object)Title ?? DBNull.Value);
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

    public static DataTable GetAllBooksData() {
      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlDataAdapter command = new SqlDataAdapter("SP_GetAllBooksData", connection);

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

    public static bool DeleteBook(int BookID) {
      int RowsAffected = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand("SP_DeleteBook", connection);
      command.CommandType = CommandType.StoredProcedure;

      command.Parameters.AddWithValue("@BookID", BookID);

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
