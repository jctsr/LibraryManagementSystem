using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem.Classes
{
  public class DataIssueBooks
  {
    private string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

    private readonly string connectionString;

    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Contact { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Email { get; set; }

    public string? Issued_Date { get; set; }

    public string? Return_Date { get; set; }

    public string? Status { get; set; }

    public DataIssueBooks()
    {
      string dbPath = Path.Combine(appDirectory, "Library.mdf");
      connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";
    }

    public List<DataIssueBooks> IssueBooksData()
    {
      List<DataIssueBooks> ListData = new List<DataIssueBooks>();

      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();

        string SelectData = "SELECT * FROM issues WHERE date_delete IS NULL";

        using SqlCommand CMD = new(SelectData, Connect);

        SqlDataReader Reader = CMD.ExecuteReader();

        while (Reader.Read())
        {
          DataIssueBooks DataIssueBooks = new()
          {
            Id = (int)Reader["id"],
            Title = Reader["title"].ToString(),
            Author = Reader["author"].ToString(),
            Name = Reader["full_name"].ToString(),
            Contact = Reader["contact"].ToString(),
            Email = Reader["email"].ToString(),
            Issued_Date = Reader["issue_date"].ToString(),
            Status = Reader["book_status"].ToString(),
          };

          ListData.Add(DataIssueBooks);
        }
        Reader.Close();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error connecting to Database: " + ex);
      }
      finally
      {
        Connect.Close();
      }

      return ListData;
    }

    public List<DataIssueBooks> ReturnIssueBooksData()
    {
      List<DataIssueBooks> ListData = [];

      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();

        string SelectData = "SELECT * FROM issues WHERE book_status = @book_status AND date_delete IS NULL";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SelectCMD.Parameters.AddWithValue("@book_status", "Issued");

        SelectCMD.ExecuteNonQuery();

        SqlDataReader Reader = SelectCMD.ExecuteReader();

        while (Reader.Read())
        {
          DataIssueBooks DataIssueBooks = new()
          {
            Id = (int)Reader["id"],
            Title = Reader["title"].ToString(),
            Author = Reader["author"].ToString(),
            Name = Reader["full_name"].ToString(),
            Contact = Reader["contact"].ToString(),
            Email = Reader["email"].ToString(),
            Issued_Date = Reader["issue_date"].ToString(),
            Return_Date = Reader["return_date"].ToString(),
            Status = Reader["book_status"].ToString(),
          };

          ListData.Add(DataIssueBooks);
        }

        Reader.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex);
        throw;
      }
      finally
      {
        Connect.Close();
      }

      return ListData;
    }
  }
}
