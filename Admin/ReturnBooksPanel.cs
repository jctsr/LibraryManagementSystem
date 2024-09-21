using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
  public partial class ReturnBooksPanel : UserControl
  {
    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vincenzo Cassano\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30";

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public ReturnBooksPanel()
    {
      InitializeComponent();

      DisplayBooks();

      DataIssueBookId();

      this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

      MakeForm_ButtonRounded.MakeButtonRounded(AddBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(ClearBtn);
    }

    public void DisplayBooks()
    {
      ListOfBooksDataGridView.AutoGenerateColumns = false;

      DataIssueBooks DataIssueBooks = new();

      List<DataIssueBooks> ListData = DataIssueBooks.ReturnIssueBooksData();

      ListOfBooksDataGridView.DataSource = null;

      ListOfBooksDataGridView.DataSource = ListData;
    }

    public void DataIssueBookId()
    {
      using SqlConnection Connect = new(_connectionString);

      try
      {
        Connect.Open();

        string SelectData = "SELECT id FROM issues WHERE book_status = 'Issued' AND date_delete IS NULL";

        using SqlCommand SelectCMD = new(SelectData, Connect);

        SqlDataAdapter DataAdapter = new(SelectCMD);

        DataTable Table = new();

        DataAdapter.Fill(Table);

        IssueIDcomboBox.DataSource = null;

        BooksPic.Image = null;

        BooksPic.ImageLocation = null;

        IssueIDcomboBox.DataSource = Table;

        IssueIDcomboBox.DisplayMember = "id";

        IssueIDcomboBox.ValueMember = "id";
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
        TitleTextBox.Text = Row.Cells[4].Value?.ToString() ?? string.Empty;
        AuthorTextBox.Text = Row.Cells[5].Value?.ToString() ?? string.Empty;

        if (Row.Cells[5].Value.ToString() != null)
        {
          ReturnDateTimePicker.Value = Convert.ToDateTime(Row.Cells[6].Value.ToString());
        }

      }
    }

    private void IssueIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (IssueIDcomboBox.SelectedValue != null)
      {
        DataRowView? SelectedRow = IssueIDcomboBox.SelectedItem as DataRowView;

        if (SelectedRow != null)
        {
          BookID = Convert.ToInt32(SelectedRow["id"]);

          using SqlConnection Connect = new(_connectionString);

          try
          {
            Connect.Open();

            string SelectData = "SELECT * FROM issues WHERE id = @id";

            using SqlCommand SelectCMD = new(SelectData, Connect);

            SelectCMD.Parameters.AddWithValue("@id", BookID);

            SqlDataAdapter Adapter = new(SelectCMD);

            DataTable Table = new();

            Adapter.Fill(Table);

            if (Table.Rows.Count > 0)
            {
              TitleTextBox.Text = Table.Rows[0]["title"].ToString();

              AuthorTextBox.Text = Table.Rows[0]["author"].ToString();

              NameTextBox.Text = Table.Rows[0]["full_name"].ToString();

              EmailTextBox.Text = Table.Rows[0]["email"].ToString();

              ContactNumberTextBox.Text = Table.Rows[0]["contact"].ToString();

              string SelectImagePath = "SELECT image_path FROM books WHERE title = @title";

              using SqlCommand SelectImagePathCMD = new(SelectImagePath, Connect);

              SelectImagePathCMD.Parameters.AddWithValue("@title", TitleTextBox.Text.Trim());

              string? ImagePath = null;

              using SqlDataReader Reader = SelectImagePathCMD.ExecuteReader();

              if (Reader.Read())
              {
                ImagePath = Reader["image_path"] as string;
              }

              if (ImagePath != null)
              {
                BooksPic.Image = Image.FromFile(ImagePath);
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
    }

    public void ClearFields()
    {
      NameTextBox.Clear();
      ContactNumberTextBox.Clear();
      EmailTextBox.Clear();
      AuthorTextBox.Clear();

      TitleTextBox.Text = string.Empty;

      BooksPic.Image = null;
      BooksPic.ImageLocation = null;
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(ContactNumberTextBox.Text) || string.IsNullOrWhiteSpace(TitleTextBox.Text) || string.IsNullOrWhiteSpace(AuthorTextBox.Text) || string.IsNullOrWhiteSpace(ReturnStatusComboBox.Text))
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

      using SqlConnection Connect = new(_connectionString);

      try
      {
        Connect.Open();

        string UpdateData = "UPDATE issues SET book_status = @book_status, return_date = @return_date, date_update = @date_update WHERE id = @id";

        using (SqlCommand UpdateCMD = new(UpdateData, Connect))
        {
          UpdateCMD.Parameters.AddWithValue("@id", BookID);
          UpdateCMD.Parameters.AddWithValue("@book_status", ReturnStatusComboBox.Text);
          UpdateCMD.Parameters.AddWithValue("@return_date", ReturnDateTimePicker.Value);
          UpdateCMD.Parameters.AddWithValue("@date_update", DateTime.Now);

          UpdateCMD.ExecuteNonQuery();

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
  }
}
