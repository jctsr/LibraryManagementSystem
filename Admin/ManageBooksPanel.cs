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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace LibraryManagementSystem
{
    public partial class ManageBooksPanel : UserControl
  {
    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vincenzo Cassano\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30";

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public ManageBooksPanel()
    {
      InitializeComponent();

      DisplayBooks();

      this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

      MakeForm_ButtonRounded.MakeButtonRounded(AddBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(DeleteBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(UpdateBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(ClearBtn);
      MakeForm_ButtonRounded.MakeButtonRounded(ImportImageBtn);
    }

    public void DisplayBooks()
    {
      ListOfBooksDataGridView.AutoGenerateColumns = false;

      DataAddBooks DataAddBooks = new();

      List<DataAddBooks> ListData = DataAddBooks.AddBooksData();

      ListOfBooksDataGridView.DataSource = null;
      ListOfBooksDataGridView.DataSource = ListData;
    }

    public void ClearFields()
    {
      AddTitleTextBox.Clear();
      AddAuthorTextBox.Clear();

      AddStatusBooksComboBox.Text = string.Empty;

      BooksPic.ImageLocation = null;

      BooksPic.Image = null;
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

        AddTitleTextBox.Text = Row.Cells[1].Value?.ToString() ?? string.Empty;
        AddAuthorTextBox.Text = Row.Cells[2].Value?.ToString() ?? string.Empty;

        if (Row.Cells[3].Value.ToString() != null)
        {
          AddPublishedDateTImePicker.Value = Convert.ToDateTime(Row.Cells[3].Value.ToString());
        }

        string? ImagePath = Row.Cells[5].Value?.ToString();

        if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
        {
          BooksPic.Image = Image.FromFile(ImagePath);
        }
        else
        {
          BooksPic.Image = null;
        }

        AddStatusBooksComboBox.Text = Row.Cells[4].Value?.ToString() ?? string.Empty;
      }
    }

    private void ImportImageBtn_Click(object sender, EventArgs e)
    {

      try
      {
        OpenFileDialog Dialog = new();

        Dialog.Filter = "Image Files (*.jpg; *.png) |*.jpg;*.png";

        if (Dialog.ShowDialog() == DialogResult.OK)
        {
          BooksPic.ImageLocation = null; 

          string ImagePath = Dialog.FileName;

          BooksPic.ImageLocation = ImagePath;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
      if (BooksPic.Image == null || string.IsNullOrWhiteSpace(AddTitleTextBox.Text) || string.IsNullOrWhiteSpace(AddAuthorTextBox.Text) || string.IsNullOrWhiteSpace(AddStatusBooksComboBox.Text))
      {
        MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      using SqlConnection Connect = new(_connectionString);

      try
      {
        Connect.Open();

        string CheckData = "SELECT COUNT(*) FROM books WHERE title = @title AND author = @author AND image_path = @image_path";

        string path = Path.Combine(@"C:\Users\Vincenzo Cassano\source\repos\LibraryManagementSystem\Books_Directory\" + AddTitleTextBox.Text.Trim() + "_" + AddAuthorTextBox.Text.Trim() + ".jpg");

        using SqlCommand CheckCMD = new(CheckData, Connect);

        string? DirectoryPath = Path.GetDirectoryName(path);

        CheckCMD.Parameters.AddWithValue("@title", AddTitleTextBox.Text.Trim());
        CheckCMD.Parameters.AddWithValue("@author", AddAuthorTextBox.Text.Trim());
        CheckCMD.Parameters.AddWithValue("@image_path", path);

        int count = (int)CheckCMD.ExecuteScalar();

        if (count > 0)
        {
          MessageBox.Show("The book with this title, author, and image already exists. Please select a new image or modify the title / author.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        if (DirectoryPath != null && !Directory.Exists(DirectoryPath))
        {
          Directory.CreateDirectory(DirectoryPath);
        }

        if (File.Exists(path))
        {
          MessageBox.Show("The book with this title and author already exists.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        // Check if BooksPic.ImageLocation is not null
        if (!string.IsNullOrEmpty(BooksPic.ImageLocation))
        {
          // Copy the image file to the target path
          File.Copy(BooksPic.ImageLocation, path, true);

          string InsertData = "INSERT INTO books (title, author, published_date, book_status, image_path) VALUES (@title, @author, @published, @status, @image)";

          using SqlCommand InsertCMD = new(InsertData, Connect);
          InsertCMD.Parameters.AddWithValue("@title", AddTitleTextBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@author", AddAuthorTextBox.Text.Trim());
          InsertCMD.Parameters.AddWithValue("@published", AddPublishedDateTImePicker.Value);
          InsertCMD.Parameters.AddWithValue("@status", AddStatusBooksComboBox.Text);
          InsertCMD.Parameters.AddWithValue("@image", path);

          InsertCMD.ExecuteNonQuery();

          DisplayBooks();

          MessageBox.Show("Added Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

          ClearFields();

          IssueBooksPanel IssueBooksPanel = new();

          IssueBooksPanel.DataBookTitle();
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
      if (BooksPic.Image == null || string.IsNullOrWhiteSpace(AddTitleTextBox.Text) || string.IsNullOrWhiteSpace(AddAuthorTextBox.Text)
        || string.IsNullOrWhiteSpace(AddStatusBooksComboBox.Text))
      {
        MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        DialogResult Result = MessageBox.Show("Are you sure you want to update book ID: " + BookID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (Result == DialogResult.Yes)
        {
          using SqlConnection Connect = new(_connectionString);

          try
          {
            Connect.Open();

            string UpdateData = "UPDATE books SET title = @title, author = @author, published_date = @published, book_status = @status, date_update = @date_update";

            using SqlCommand UpdateCMD = new(UpdateData, Connect);

            UpdateCMD.Parameters.AddWithValue("@title", AddTitleTextBox.Text.Trim());
            UpdateCMD.Parameters.AddWithValue("@author", AddAuthorTextBox.Text.Trim());
            UpdateCMD.Parameters.AddWithValue("@published", AddPublishedDateTImePicker.Value);
            UpdateCMD.Parameters.AddWithValue("@status", AddStatusBooksComboBox.Text);
            UpdateCMD.Parameters.AddWithValue("@date_update", DateTime.Now);
            UpdateCMD.Parameters.AddWithValue("@id", BookID);

            //if (BooksPic.ImageLocation != null && BooksPic.Image != null)
            //{
            //  string path = Path.Combine(@"C:\Users\Vincenzo Cassano\source\repos\LibraryManagementSystem\Books_Directory\",
            //                               $"{AddTitleTextBox.Text.Trim()}_{AddAuthorTextBox.Text.Trim()}.jpg");

            //  string? DirectoryPath = Path.GetDirectoryName(path);

            //  if(DirectoryPath != null && !Directory.Exists(DirectoryPath))
            //  {
            //    Directory.CreateDirectory(path);
            //  }

            //  File.Copy(BooksPic.ImageLocation, path, true);

            //  UpdateData += ",image_path = @image";

            //  UpdateCMD.Parameters.AddWithValue("@image", path);
            //}

            UpdateData += " WHERE id = @id";

            UpdateCMD.CommandText = UpdateData;

            UpdateCMD.ExecuteNonQuery();

            DisplayBooks();

            MessageBox.Show("Updated Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();

            IssueBooksPanel IssueBooksPanel = new();

            IssueBooksPanel.DataBookTitle();
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
        else
        {
          MessageBox.Show("Update Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
      if (BooksPic.Image == null || string.IsNullOrWhiteSpace(AddTitleTextBox.Text) || string.IsNullOrWhiteSpace(AddAuthorTextBox.Text)
       || string.IsNullOrWhiteSpace(AddStatusBooksComboBox.Text))
      {
        MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        DialogResult Result = MessageBox.Show("Are you sure you want to delete book ID: " + BookID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (Result == DialogResult.Yes)
        {
          using SqlConnection Connect = new(_connectionString);

          try
          {
            Connect.Open();

            string UpdateData = "UPDATE books SET date_delete = @date_delete WHERE id = @id";

            using SqlCommand UpdateCMD = new(UpdateData, Connect);

            UpdateCMD.Parameters.AddWithValue("@date_delete", DateTime.Now);
            UpdateCMD.Parameters.AddWithValue("@id", BookID);

            UpdateCMD.ExecuteNonQuery();

            DisplayBooks();

            MessageBox.Show("Deleted Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();

            IssueBooksPanel IssueBooksPanel = new();

            IssueBooksPanel.DataBookTitle();
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
        else
        {
          MessageBox.Show("Delete Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e)
    {
      ClearFields();
    }
  }
}
