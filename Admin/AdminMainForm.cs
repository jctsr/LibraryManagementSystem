using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
  public partial class AdminMainForm : Form
  {
    private string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

    private readonly string connectionString;

    private ManageBooksPanel ManageBooksPanel = new();

    private IssueBooksPanel IssueBooksPanel = new();

    private ReturnBooksPanel ReturnBooksPanel = new();

    private Draggable Draggable = new();

    readonly MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public AdminMainForm()
    {
      InitializeComponent();

      string dbPath = Path.Combine(appDirectory, "Library.mdf");
      connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";

      Draggable.MakeDraggable(TopPanel);

      ShowUserLabel();

      DisplayAvailableBooks();
      DisplayIssuedBooks();
      DisplayReturnedBooks();

      DisplayAllBooks();

      //this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
      MakeForm_ButtonRounded.MakeButtonRounded(AdminDashboardBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(AdminBooksBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(AdminIssueBooksBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(AdminReturnBooksBtn);
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes) Application.Exit();
    }

    public void RefreshData()
    {

      if (InvokeRequired)
      {
        Invoke((MethodInvoker)RefreshData);
        return;
      }

      DisplayAvailableBooks();
      DisplayIssuedBooks();
      DisplayReturnedBooks();
    }


    public void DisplayAvailableBooks()
    {
      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();

        string SelectData = "SELECT COUNT(id) FROM books WHERE book_status = @book_status AND date_delete IS NULL";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SelectCMD.Parameters.AddWithValue("@book_status", "Available");

        using SqlDataReader reader = SelectCMD.ExecuteReader();
        int tempAB = 0;

        if (reader.Read())
        {
          tempAB = Convert.ToInt32(reader[0]);

          TotalAvailableBooksLabel.Text = tempAB.ToString();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        Connect.Close();
      }
    }

    public void DisplayIssuedBooks()
    {
      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();
        string SelectData = "SELECT COUNT(id) FROM issues WHERE book_status = @book_status AND date_delete IS NULL";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SelectCMD.Parameters.AddWithValue("@book_status", "Issued");

        using SqlDataReader reader = SelectCMD.ExecuteReader();
        int tempIB = 0;

        if (reader.Read())
        {
          tempIB = Convert.ToInt32(reader[0]);

          TotalIssuedBooksLabel.Text = tempIB.ToString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        Connect.Close();
      }
    }

    public void DisplayReturnedBooks()
    {
      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();
        string SelectData = "SELECT COUNT(id) FROM issues WHERE book_status = @book_status AND date_delete IS NULL";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SelectCMD.Parameters.AddWithValue("@book_status", "returned");

        using SqlDataReader reader = SelectCMD.ExecuteReader();
        int tempRB = 0;

        if (reader.Read())
        {
          tempRB = Convert.ToInt32(reader[0]);

          TotalReturnedBooksLabel.Text = tempRB.ToString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        Connect.Close();
      }
    }

    private void ShowUserLabel()
    {
      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();

        string SelectData = "SELECT username FROM users WHERE active_status = @active_status";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SelectCMD.Parameters.AddWithValue("@active_status", "active");

        SqlDataAdapter Adapter = new(SelectCMD);

        DataTable Table = new();

        Adapter.Fill(Table);

        if (Table.Rows.Count > 0)
        {
          UsernameLabel.Text = Table.Rows[0]["username"].ToString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        throw;
      }
      finally
      {
        Connect.Close();
      }
    }

    public void DisplayAllBooks()
    {
      ListOfBooksDataGridView.AutoGenerateColumns = false;

      DataAllBooks DataAllBooks = new();

      List<DataAllBooks> ListDataBooks = DataAllBooks.ShowAllBooksData();

      ListOfBooksDataGridView.DataSource = null;
      ListOfBooksDataGridView.DataSource = ListDataBooks;
    }


    private void LogOutBtn_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure want to logout?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes)
      {
        using SqlConnection Connect = new(connectionString);

        try
        {
          Connect.Open();

          string UpdateUserStatus = "UPDATE users SET active_status = @active_status WHERE username = @username";

          using SqlCommand UpdateCMD = new(UpdateUserStatus, Connect);

          UpdateCMD.Parameters.AddWithValue("@username", UsernameLabel.Text);
          UpdateCMD.Parameters.AddWithValue("@active_status", "unactive");

          UpdateCMD.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          throw;
        }
        finally
        {
          Connect.Close();
        }

        LoginForm LoginForm = new();

        LoginForm.Show();

        this.Close();
      }
    }
    private void AdminDashboardBtn_Click(object sender, EventArgs e)
    {
      this.Controls.Remove(ManageBooksPanel);

      this.Controls.Remove(IssueBooksPanel);

      this.Controls.Remove(ReturnBooksPanel);

      DisplayAllBooks();
      DisplayAvailableBooks();
      DisplayIssuedBooks();
      DisplayReturnedBooks();

      AdminDisplayPanel.Visible = true;

      AllBooksPanel.Visible = true;
    }

    private void AdminBooksBtn_Click(object sender, EventArgs e)
    {
      this.Controls.Remove(IssueBooksPanel);

      this.Controls.Remove(ReturnBooksPanel);

      this.Controls.Add(ManageBooksPanel);

      // Get the current DPI scale factor
      float dpiScale = this.DeviceDpi / 96f; // 96 DPI is the default

      // Adjust position based on DPI scale
      int adjustedX = (int)(436 * dpiScale);
      int adjustedY = (int)(61 * dpiScale);

      ManageBooksPanel.Location = new Point(adjustedX, adjustedY);

      AdminDisplayPanel.Visible = false;

      AllBooksPanel.Visible = false;
    }

    private void AdminIssueBooksBtn_Click(object sender, EventArgs e)
    {
      this.Controls.Remove(ManageBooksPanel);

      this.Controls.Remove(ReturnBooksPanel);

      this.Controls.Add(IssueBooksPanel);

      IssueBooksPanel.DisplayBooks();
      IssueBooksPanel.DataBookTitle();

      // Get the current DPI scale factor
      float dpiScale = this.DeviceDpi / 96f; // 96 DPI is the default

      // Adjust position based on DPI scale
      int adjustedX = (int)(436 * dpiScale);
      int adjustedY = (int)(61 * dpiScale);

      IssueBooksPanel.Location = new Point(adjustedX, adjustedY);

      //IssueBooksPanel.Location = new Point(436, 61);

      AdminDisplayPanel.Visible = false;

      AllBooksPanel.Visible = false;
    }

    private void AdminReturnBooksBtn_Click(object sender, EventArgs e)
    {
      this.Controls.Remove(ManageBooksPanel);

      this.Controls.Remove(IssueBooksPanel);

      this.Controls.Add(ReturnBooksPanel);

      ReturnBooksPanel.DisplayBooks();
      ReturnBooksPanel.DataIssueBookId();

      // Get the current DPI scale factor
      float dpiScale = this.DeviceDpi / 96f; // 96 DPI is the default

      // Adjust position based on DPI scale
      int adjustedX = (int)(436 * dpiScale);
      int adjustedY = (int)(61 * dpiScale);

      ReturnBooksPanel.Location = new Point(adjustedX, adjustedY);

      //IssueBooksPanel.Location = new Point(436, 61);

      AdminDisplayPanel.Visible = false;

      AllBooksPanel.Visible = false;
    }
  }
}
