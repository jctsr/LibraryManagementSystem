namespace LibraryManagementSystem
{
  partial class RegisterForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      LeftPictureBox = new PictureBox();
      TopPanel = new Panel();
      closeBtn = new Button();
      UsernameLabel = new Label();
      AlreadyHaveAnAccountLabel = new Label();
      UserShowPasswordCheckBox = new CheckBox();
      UserRegisterBtn = new Button();
      UserRegisterPasswordTextBox = new TextBox();
      UserPasswordLabel = new Label();
      EmailRegisterTextBox = new TextBox();
      EmailLabel = new Label();
      UserRegisterTitle = new Label();
      UsernameRegisterTextBox = new TextBox();
      ((System.ComponentModel.ISupportInitialize)LeftPictureBox).BeginInit();
      TopPanel.SuspendLayout();
      SuspendLayout();
      // 
      // LeftPictureBox
      // 
      LeftPictureBox.Image = Properties.Resources.magical_library;
      LeftPictureBox.Location = new Point(0, 0);
      LeftPictureBox.Name = "LeftPictureBox";
      LeftPictureBox.Size = new Size(412, 600);
      LeftPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
      LeftPictureBox.TabIndex = 11;
      LeftPictureBox.TabStop = false;
      // 
      // TopPanel
      // 
      TopPanel.BackColor = SystemColors.Control;
      TopPanel.Controls.Add(closeBtn);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(0, 0);
      TopPanel.Name = "TopPanel";
      TopPanel.Size = new Size(800, 40);
      TopPanel.TabIndex = 10;
      // 
      // closeBtn
      // 
      closeBtn.BackColor = SystemColors.Control;
      closeBtn.Cursor = Cursors.Hand;
      closeBtn.FlatAppearance.BorderSize = 0;
      closeBtn.FlatStyle = FlatStyle.Flat;
      closeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      closeBtn.ForeColor = SystemColors.ControlText;
      closeBtn.Location = new Point(732, 1);
      closeBtn.Name = "closeBtn";
      closeBtn.Size = new Size(68, 38);
      closeBtn.TabIndex = 7;
      closeBtn.TabStop = false;
      closeBtn.Text = "X";
      closeBtn.UseVisualStyleBackColor = false;
      closeBtn.Click += closeBtn_Click;
      // 
      // UsernameLabel
      // 
      UsernameLabel.AutoSize = true;
      UsernameLabel.Font = new Font("Segoe UI", 12F);
      UsernameLabel.Location = new Point(466, 250);
      UsernameLabel.Name = "UsernameLabel";
      UsernameLabel.Size = new Size(81, 21);
      UsernameLabel.TabIndex = 29;
      UsernameLabel.Text = "Username";
      // 
      // AlreadyHaveAnAccountLabel
      // 
      AlreadyHaveAnAccountLabel.AutoSize = true;
      AlreadyHaveAnAccountLabel.Cursor = Cursors.Hand;
      AlreadyHaveAnAccountLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      AlreadyHaveAnAccountLabel.Location = new Point(525, 478);
      AlreadyHaveAnAccountLabel.Name = "AlreadyHaveAnAccountLabel";
      AlreadyHaveAnAccountLabel.Size = new Size(179, 19);
      AlreadyHaveAnAccountLabel.TabIndex = 6;
      AlreadyHaveAnAccountLabel.Text = "Already have an account?";
      AlreadyHaveAnAccountLabel.Click += AlreadyHaveAnAccountLabel_Click;
      // 
      // UserShowPasswordCheckBox
      // 
      UserShowPasswordCheckBox.AutoSize = true;
      UserShowPasswordCheckBox.Cursor = Cursors.Hand;
      UserShowPasswordCheckBox.FlatAppearance.BorderSize = 0;
      UserShowPasswordCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      UserShowPasswordCheckBox.Location = new Point(466, 389);
      UserShowPasswordCheckBox.Name = "UserShowPasswordCheckBox";
      UserShowPasswordCheckBox.Size = new Size(112, 19);
      UserShowPasswordCheckBox.TabIndex = 4;
      UserShowPasswordCheckBox.Text = "Show Password";
      UserShowPasswordCheckBox.UseVisualStyleBackColor = true;
      UserShowPasswordCheckBox.CheckedChanged += UserShowPasswordCheckBox_CheckedChanged;
      // 
      // UserRegisterBtn
      // 
      UserRegisterBtn.BackColor = Color.Green;
      UserRegisterBtn.Cursor = Cursors.Hand;
      UserRegisterBtn.FlatStyle = FlatStyle.Flat;
      UserRegisterBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      UserRegisterBtn.ForeColor = SystemColors.ControlLightLight;
      UserRegisterBtn.Location = new Point(466, 427);
      UserRegisterBtn.Name = "UserRegisterBtn";
      UserRegisterBtn.Size = new Size(289, 39);
      UserRegisterBtn.TabIndex = 5;
      UserRegisterBtn.Text = "Register";
      UserRegisterBtn.UseVisualStyleBackColor = false;
      UserRegisterBtn.Click += UserRegisterBtn_Click;
      // 
      // UserRegisterPasswordTextBox
      // 
      UserRegisterPasswordTextBox.Font = new Font("Segoe UI", 12F);
      UserRegisterPasswordTextBox.Location = new Point(466, 350);
      UserRegisterPasswordTextBox.Name = "UserRegisterPasswordTextBox";
      UserRegisterPasswordTextBox.PasswordChar = '*';
      UserRegisterPasswordTextBox.PlaceholderText = "Enter Password";
      UserRegisterPasswordTextBox.Size = new Size(289, 29);
      UserRegisterPasswordTextBox.TabIndex = 3;
      UserRegisterPasswordTextBox.KeyPress += UserRegisterPasswordTextBox_KeyPress;
      // 
      // UserPasswordLabel
      // 
      UserPasswordLabel.AutoSize = true;
      UserPasswordLabel.Font = new Font("Segoe UI", 12F);
      UserPasswordLabel.Location = new Point(466, 319);
      UserPasswordLabel.Name = "UserPasswordLabel";
      UserPasswordLabel.Size = new Size(76, 21);
      UserPasswordLabel.TabIndex = 24;
      UserPasswordLabel.Text = "Password";
      // 
      // EmailRegisterTextBox
      // 
      EmailRegisterTextBox.Font = new Font("Segoe UI", 12F);
      EmailRegisterTextBox.Location = new Point(466, 208);
      EmailRegisterTextBox.Name = "EmailRegisterTextBox";
      EmailRegisterTextBox.PlaceholderText = "Enter Email";
      EmailRegisterTextBox.Size = new Size(289, 29);
      EmailRegisterTextBox.TabIndex = 1;
      // 
      // EmailLabel
      // 
      EmailLabel.AutoSize = true;
      EmailLabel.Font = new Font("Segoe UI", 12F);
      EmailLabel.Location = new Point(466, 177);
      EmailLabel.Name = "EmailLabel";
      EmailLabel.Size = new Size(48, 21);
      EmailLabel.TabIndex = 22;
      EmailLabel.Text = "Email";
      // 
      // UserRegisterTitle
      // 
      UserRegisterTitle.AutoSize = true;
      UserRegisterTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
      UserRegisterTitle.Location = new Point(466, 134);
      UserRegisterTitle.Name = "UserRegisterTitle";
      UserRegisterTitle.Size = new Size(90, 28);
      UserRegisterTitle.TabIndex = 21;
      UserRegisterTitle.Text = "Register";
      // 
      // UsernameRegisterTextBox
      // 
      UsernameRegisterTextBox.Font = new Font("Segoe UI", 12F);
      UsernameRegisterTextBox.Location = new Point(466, 283);
      UsernameRegisterTextBox.Name = "UsernameRegisterTextBox";
      UsernameRegisterTextBox.PlaceholderText = "Enter Username";
      UsernameRegisterTextBox.Size = new Size(289, 29);
      UsernameRegisterTextBox.TabIndex = 2;
      // 
      // RegisterForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 600);
      Controls.Add(UsernameRegisterTextBox);
      Controls.Add(UsernameLabel);
      Controls.Add(AlreadyHaveAnAccountLabel);
      Controls.Add(UserShowPasswordCheckBox);
      Controls.Add(UserRegisterBtn);
      Controls.Add(UserRegisterPasswordTextBox);
      Controls.Add(UserPasswordLabel);
      Controls.Add(EmailRegisterTextBox);
      Controls.Add(EmailLabel);
      Controls.Add(UserRegisterTitle);
      Controls.Add(LeftPictureBox);
      Controls.Add(TopPanel);
      FormBorderStyle = FormBorderStyle.None;
      Name = "RegisterForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "RegisterForm";
      ((System.ComponentModel.ISupportInitialize)LeftPictureBox).EndInit();
      TopPanel.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private PictureBox LeftPictureBox;
    private Panel TopPanel;
    private Button closeBtn;
    private Label UsernameLabel;
    private Label AlreadyHaveAnAccountLabel;
    private CheckBox UserShowPasswordCheckBox;
    private Button UserRegisterBtn;
    private TextBox UserRegisterPasswordTextBox;
    private Label UserPasswordLabel;
    private TextBox EmailRegisterTextBox;
    private Label EmailLabel;
    private Label UserRegisterTitle;
    private TextBox UsernameRegisterTextBox;
  }
}