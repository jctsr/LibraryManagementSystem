using System.Data;
using System.Data.SqlClient;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
  {
    SqlConnection connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vincenzo Cassano\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");

    private Draggable Draggable = new();

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public RegisterForm()
    {
      InitializeComponent();

      this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

      Draggable.MakeDraggable(TopPanel);
      Draggable.MakeDraggable(LeftPictureBox);

      MakeForm_ButtonRounded.MakeButtonRounded(UserRegisterBtn);
    }

    private void AlreadyHaveAnAccountLabel_Click(object sender, EventArgs e)
    {
      LoginForm LoginForm = new LoginForm();

      LoginForm.Show();

      this.Close();
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes) Application.Exit();
    }

    private bool IsValidEmail(string email)
    {
      try
      {
        var addr = new System.Net.Mail.MailAddress(email);

        return addr.Address == email;
      }
      catch (Exception)
      {
        return false;
      }
    }

    private void Register()
    {
      if
     (
       string.IsNullOrWhiteSpace(EmailRegisterTextBox.Text) ||
       string.IsNullOrWhiteSpace(UsernameRegisterTextBox.Text) ||
       string.IsNullOrWhiteSpace(UserRegisterPasswordTextBox.Text)
     )
      {
        MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
     
      if (!IsValidEmail(EmailRegisterTextBox.Text.Trim()))
      {
        MessageBox.Show("Please enter a valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      else
      {
        if (connect.State != ConnectionState.Open)
        {
          try
          {
            connect.Open();

            string CheckUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

            using SqlCommand CheckCMD = new(CheckUsername, connect);

            CheckCMD.Parameters.AddWithValue("@username", UsernameRegisterTextBox.Text.Trim());

            int count = (int)CheckCMD.ExecuteScalar();

            if (count >= 1)
            {
              MessageBox.Show(UsernameRegisterTextBox.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              string InsertData = "INSERT INTO users (email, username, pwd, date_register)" + "VALUES(@email, @username, @password, @date)";

              using SqlCommand InsertCMD = new(InsertData, connect);

              InsertCMD.Parameters.AddWithValue("@email", EmailRegisterTextBox.Text.Trim());
              InsertCMD.Parameters.AddWithValue("@username", UsernameRegisterTextBox.Text.Trim());
              InsertCMD.Parameters.AddWithValue("@password", UserRegisterPasswordTextBox.Text.Trim());
              InsertCMD.Parameters.AddWithValue("@date", DateTime.Now);

              InsertCMD.ExecuteNonQuery();

              MessageBox.Show("Register Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

              LoginForm LoginForm = new();

              LoginForm.Show();

              this.Close();
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
    }

    private void UserRegisterBtn_Click(object sender, EventArgs e)
    {
      Register();
    }

    private void UserRegisterPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter) Register();
    }

    private void UserShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      UserRegisterPasswordTextBox.PasswordChar = UserShowPasswordCheckBox.Checked ? '\0' : '*';
    }
  }//end of form
}
