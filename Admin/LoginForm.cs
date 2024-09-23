using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
  {
    private string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

    private readonly string connectionString;

    //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Library.mdf;Integrated Security=True;Connect Timeout=30";

    Draggable Draggable = new();

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public LoginForm()
    {
      InitializeComponent();

      //connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

      string dbPath = Path.Combine(appDirectory, "Library.mdf");
      connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";


      //this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

      Draggable.MakeDraggable(TopPanel);
      Draggable.MakeDraggable(LeftPictureBox);

      MakeForm_ButtonRounded.MakeButtonRounded(UserLoginBtn);

      LoadingScreen LoadingScreen = new();

      LoadingScreen.Close();
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes) Application.Exit();
    }

    private void Login()
    {
      if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(UserPasswordTextBox.Text))
      {
        //MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        MessageBox.Show(appDirectory, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        using SqlConnection connect = new(connectionString);

        try
        {
          connect.Open();

          string selectData = "SELECT * FROM users WHERE username = @username AND pwd = @password";

          using SqlCommand selectCmd = new(selectData, connect);

          selectCmd.Parameters.AddWithValue("@username", UsernameTextBox.Text.Trim());
          selectCmd.Parameters.AddWithValue("@password", UserPasswordTextBox.Text.Trim());

          using SqlDataReader reader = selectCmd.ExecuteReader();

          if (reader.HasRows)
          {
            reader.Read();
            string? storedUsername = reader["username"].ToString();
            string? storedPassword = reader["pwd"].ToString();

            //MessageBox.Show($"Debug: Stored Username: {storedUsername}, Stored Password: {storedPassword}", "Debug Info");

            if (storedUsername == UsernameTextBox.Text.Trim() && storedPassword == UserPasswordTextBox.Text.Trim())
            {
              MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

              reader.Close();

              string updateUserStatus = "UPDATE users SET active_status = @active_status WHERE username = @username";

              using SqlCommand updateCmd = new(updateUserStatus, connect);

              updateCmd.Parameters.AddWithValue("@username", UsernameTextBox.Text.Trim());

              updateCmd.Parameters.AddWithValue("@active_status", "active");

              updateCmd.ExecuteNonQuery();

              AdminMainForm adminMainForm = new();
              adminMainForm.Show();

              this.Close();
            }
            else
            {
              MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          else
          {
            MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error connecting to the Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          connect.Close();
        }
      }
    }

    private void UserLoginBtn_Click(object sender, EventArgs e)
    {
      Login();
    }

    private void UserPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter) Login();
    }

    private void UserShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      UserPasswordTextBox.PasswordChar = UserShowPasswordCheckBox.Checked ? '\0' : '*';
    }

    private void RegisterAccountLabel_Click(object sender, EventArgs e)
    {
      RegisterForm RegisterForm = new();

      RegisterForm.Show();

      this.Close();
    }

    private void SwitchAdminBtn_Click(object sender, EventArgs e)
    {

    }
  }//end of form
}
