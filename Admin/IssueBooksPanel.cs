using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LibraryManagementSystem
{
    public partial class IssueBooksPanel : UserControl
  {
    private string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

    private readonly string connectionString;

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public IssueBooksPanel()
    {
      InitializeComponent();

      this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

      string dbPath = Path.Combine(appDirectory, "Library.mdf");
      connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";

      DisplayBooks();

      DataBookTitle();

      MakeForm_ButtonRounded.MakeButtonRounded(AddBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(DeleteBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(UpdateBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(ClearBtn);
    }

    public void DisplayBooks()
    {
      ListOfBooksDataGridView.AutoGenerateColumns = false;

      DataIssueBooks DataIssueBooks = new();

      List<DataIssueBooks> ListDataIssue = DataIssueBooks.IssueBooksData();

      ListOfBooksDataGridView.DataSource = null;
      ListOfBooksDataGridView.DataSource = ListDataIssue;

    }

    public void DataBookTitle()
    {
      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();

        string SelectData = "SELECT id, title FROM books WHERE book_status = 'Available' AND date_delete IS NULL";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SqlDataAdapter DataAdapter = new(SelectCMD);

        DataTable Table = new();

        DataAdapter.Fill(Table);

        TitleComboBox.DataSource = null;

        BooksPic.Image = null;

        BooksPic.ImageLocation = null;

        TitleComboBox.DataSource = Table;

        TitleComboBox.DisplayMember = "title";

        TitleComboBox.ValueMember = "id";
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

    private int BookID = 0;

    private void ListOfBooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && ListOfBooksDataGridView.Rows.Count > e.RowIndex)
      {
        DataGridViewRow Row = ListOfBooksDataGridView.Rows[e.RowIndex];

        if (Row.Cells[0].Value != null && int.TryParse(Row.Cells[0].Value.ToString(), out int bookID))
        {
          BookID = bookID;
        }

        NameTextBox.Text = Row.Cells[1].Value?.ToString() ?? string.Empty;
        EmailTextBox.Text = Row.Cells[2].Value?.ToString() ?? string.Empty;
        ContactNumberTextBox.Text = Row.Cells[3].Value?.ToString() ?? string.Empty;
        TitleComboBox.Text = Row.Cells[4].Value?.ToString() ?? string.Empty;
        AuthorTextBox.Text = Row.Cells[5].Value?.ToString() ?? string.Empty;

        if (Row.Cells[5].Value.ToString() != null)
        {
          IssueDateTimePicker.Value = Convert.ToDateTime(Row.Cells[6].Value.ToString());
        }

        using SqlConnection Connect = new(connectionString);

        try
        {
          Connect.Open();

          string SelectData = "SELECT image_path FROM books WHERE id = @id";
          using SqlCommand SelectCMD = new(SelectData, Connect);

          SelectCMD.Parameters.AddWithValue("@id", BookID);

          SqlDataAdapter Adapter = new(SelectCMD);

          DataTable Table = new();

          Adapter.Fill(Table);

          if (Table.Rows.Count > 0)
          {
            string? imagePath = Table.Rows[0]["image_path"].ToString();

            if (imagePath != null)
            {
              BooksPic.Image = Image.FromFile(imagePath);
            }
            else
            {
              BooksPic.Image = null;
            }
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


        IssueStatusComboBox.Text = Row.Cells[7].Value?.ToString() ?? string.Empty;
      }
    }

    private void TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (TitleComboBox.SelectedValue != null)
      {
        DataRowView? SelectedRow = TitleComboBox.SelectedItem as DataRowView;

        int SelectID = 0;

        if (SelectedRow != null) 
        {
          SelectID = Convert.ToInt32(SelectedRow["id"]);
        }

        using SqlConnection Connect = new(connectionString);

        try
        {
          Connect.Open();

          string SelectData = "SELECT * FROM books WHERE id = @id AND book_status = @book_status";

          using SqlCommand SelectCMD = new(SelectData, Connect);

          SelectCMD.Parameters.AddWithValue("@id", SelectID);
          SelectCMD.Parameters.AddWithValue("@book_status", "Available");

          SqlDataAdapter Adapter = new(SelectCMD);

          DataTable Table = new();

          Adapter.Fill(Table);

          if (Table.Rows.Count > 0)
          {
            AuthorTextBox.Text = Table.Rows[0]["author"].ToString();

            string? imagePath = Table.Rows[0]["image_path"].ToString();

            if (imagePath != null)
            {
              BooksPic.Image = Image.FromFile(imagePath);
            }
            else
            {
              BooksPic.Image = null;
            }
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
    }

    public void ClearFields()
    {
      NameTextBox.Clear();
      ContactNumberTextBox.Clear();
      EmailTextBox.Clear();
      AuthorTextBox.Clear();

      TitleComboBox.Text = string.Empty;

      BooksPic.Image = null;
      BooksPic.ImageLocation = null;
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(ContactNumberTextBox.Text) || string.IsNullOrWhiteSpace(TitleComboBox.Text) || string.IsNullOrWhiteSpace(AuthorTextBox.Text) || string.IsNullOrWhiteSpace(IssueStatusComboBox.Text))
      {
        MessageBox.Show("Please fill all the blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!CheckEmail.IsValidEmail(EmailTextBox.Text.Trim()))
      {
        MessageBox.Show("Please enter a valid email!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!PhoneNumberValidator.IsValidPhoneNumber(ContactNumberTextBox.Text.Trim()))
      {
        MessageBox.Show("Please enter a valid phone number! It must contain fewer than 12 digits.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      using SqlConnection Connect = new(connectionString);

      try
      {
        Connect.Open();

        string CheckData = "SELECT COUNT(*) FROM issues WHERE email = @email AND title = @title";

        using SqlCommand CheckCMD = new(CheckData, Connect);

        CheckCMD.Parameters.AddWithValue("@email", EmailTextBox.Text.Trim());
        CheckCMD.Parameters.AddWithValue("@title", TitleComboBox.Text.Trim());

        int count = (int)CheckCMD.ExecuteScalar();

        if (count > 0)
        {
          MessageBox.Show(EmailTextBox.Text.Trim() + " is already issued this book", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        string CheckIssuedStatus = "SELECT COUNT(*) FROM issues WHERE title = @title AND book_status = @book_status";

        using SqlCommand CheckIssuedStatusCMD = new(CheckIssuedStatus, Connect);

        CheckIssuedStatusCMD.Parameters.AddWithValue("@title", TitleComboBox.Text.Trim());
        CheckIssuedStatusCMD.Parameters.AddWithValue("@book_status", "Issued");

        int count1 = (int)CheckIssuedStatusCMD.ExecuteScalar();

        if (count1 > 0)
        {
          MessageBox.Show("This book: " + "'" + TitleComboBox.Text.Trim() + "'" + " is already issued", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        string InsertData = "INSERT INTO issues (full_name, contact, email, title, author, book_status, issue_date) VALUES (@full_name, @contact, @email, @title, @author, @book_status, @issue_date)";

        using (SqlCommand InsertCMD = new(InsertData, Connect))
        {
          //InsertCMD.Parameters.AddWithValue("@issue_id", BookID);
          InsertCMD.Parameters.AddWithValue("@full_name", NameTextBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@contact", ContactNumberTextBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@email", EmailTextBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@title", TitleComboBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@author", AuthorTextBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@book_status", IssueStatusComboBox.Text);

          InsertCMD.Parameters.AddWithValue("@issue_date", IssueDateTimePicker.Value);

          InsertCMD.ExecuteNonQuery();

          DisplayBooks();

          MessageBox.Show("Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

          ClearFields();
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

    private void UpdateBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(ContactNumberTextBox.Text) || string.IsNullOrWhiteSpace(TitleComboBox.Text) || string.IsNullOrWhiteSpace(AuthorTextBox.Text) || string.IsNullOrWhiteSpace(IssueStatusComboBox.Text))
      {
        MessageBox.Show("Please fill all the blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      if (!CheckEmail.IsValidEmail(EmailTextBox.Text.Trim()))
      {
        MessageBox.Show("Please enter a valid email!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!PhoneNumberValidator.IsValidPhoneNumber(ContactNumberTextBox.Text.Trim()))
      {
        MessageBox.Show("Please enter a valid phone number! It must contain fewer than 12 digits.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Issue ID:"
                     + BookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (check == DialogResult.Yes)
      {
        using SqlConnection Connect = new(connectionString);

        try
        {
          Connect.Open();

          string UpdateData = "UPDATE issues SET full_name = @full_name, contact = @contact, email = @email, title = @title, author = @author, book_status = @book_status, issue_date = @issue_date, date_update = @date_update WHERE id = " + BookID;

          using SqlCommand UpdateCMD = new(UpdateData, Connect);

          UpdateCMD.Parameters.AddWithValue("@full_name", NameTextBox.Text.Trim());
          UpdateCMD.Parameters.AddWithValue("@contact", ContactNumberTextBox.Text.Trim());
          UpdateCMD.Parameters.AddWithValue("@email", EmailTextBox.Text.Trim());
          UpdateCMD.Parameters.AddWithValue("@title", TitleComboBox.Text.Trim());
          UpdateCMD.Parameters.AddWithValue("@author", AuthorTextBox.Text.Trim());
          UpdateCMD.Parameters.AddWithValue("@book_status", IssueStatusComboBox.Text);
          UpdateCMD.Parameters.AddWithValue("@issue_date", IssueDateTimePicker.Value);
          UpdateCMD.Parameters.AddWithValue("@date_update", DateTime.Today);

          UpdateCMD.ExecuteNonQuery();

          DisplayBooks();

          MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

          ClearFields();
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
      else
      {
        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e)
    {
      ClearFields();
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(ContactNumberTextBox.Text) || string.IsNullOrWhiteSpace(TitleComboBox.Text) || string.IsNullOrWhiteSpace(AuthorTextBox.Text) || string.IsNullOrWhiteSpace(IssueStatusComboBox.Text))
      {
        MessageBox.Show("Please select an item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      DialogResult Check = MessageBox.Show("Are you sure you want to delete ID: "
                        + BookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (Check == DialogResult.Yes)
      {
        using SqlConnection Connect = new(connectionString);

        try
        {
          Connect.Open();

          string UpdateData = "UPDATE issues SET date_delete = @date_delete WHERE id = @id";

          using SqlCommand UpdateCMD = new(UpdateData, Connect);

          UpdateCMD.Parameters.AddWithValue("@date_delete", DateTime.Now);
          UpdateCMD.Parameters.AddWithValue("@id", BookID);

          UpdateCMD.ExecuteNonQuery();

          DisplayBooks();

          MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

          ClearFields();  

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
      else
      {
        MessageBox.Show("Delete Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

  }
}
