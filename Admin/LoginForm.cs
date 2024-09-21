using System.Data;
using System.Data.SqlClient;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
  {
    SqlConnection connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vincenzo Cassano\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");

    Draggable Draggable = new();

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public LoginForm()
    {
      InitializeComponent();

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

    //login function
    private void Login()
    {
      if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(UserPasswordTextBox.Text))
      {
        MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        if (connect.State != ConnectionState.Open)
        {
          try
          {
            connect.Open();

            string SelectData = "SELECT * FROM users WHERE username = @username AND pwd = @password";

            using SqlCommand SelectCMD = new(SelectData, connect);

            SelectCMD.Parameters.AddWithValue("@username", UsernameTextBox.Text.Trim());
            SelectCMD.Parameters.AddWithValue("@password", UserPasswordTextBox.Text.Trim());

            SqlDataAdapter Adapter = new(SelectCMD);
            DataTable Table = new();
            Adapter.Fill(Table);

            if (Table.Rows.Count >= 1)
            {
              MessageBox.Show("Login Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

              string UpdateUserStatus = "UPDATE users SET active_status = @active_status WHERE username = @username";

              using SqlCommand UpdateCMD = new(UpdateUserStatus, connect);

              UpdateCMD.Parameters.AddWithValue("@username", UsernameTextBox.Text.Trim());
              UpdateCMD.Parameters.AddWithValue("@active_status", "active");

              UpdateCMD.ExecuteNonQuery();

              AdminMainForm AdminMainForm = new();

              AdminMainForm.Show();

              this.Close();
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
        }//end of if (connect.State != ConnectionState.Open)
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
