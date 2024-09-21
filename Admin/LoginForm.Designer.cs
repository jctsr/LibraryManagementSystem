namespace LibraryManagementSystem
{
  partial class LoginForm
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
      TopPanel = new Panel();
      closeBtn = new Button();
      LeftPictureBox = new PictureBox();
      UserLoginTitle = new Label();
      UsernameLabel = new Label();
      UsernameTextBox = new TextBox();
      UserPasswordTextBox = new TextBox();
      UserPasswordLabel = new Label();
      UserLoginBtn = new Button();
      UserShowPasswordCheckBox = new CheckBox();
      RegisterAccountLabel = new Label();
      TopPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)LeftPictureBox).BeginInit();
      SuspendLayout();
      // 
      // TopPanel
      // 
      TopPanel.BackColor = Color.Transparent;
      TopPanel.Controls.Add(closeBtn);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(0, 0);
      TopPanel.Name = "TopPanel";
      TopPanel.Size = new Size(800, 40);
      TopPanel.TabIndex = 0;
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
      closeBtn.TabIndex = 6;
      closeBtn.TabStop = false;
      closeBtn.Text = "X";
      closeBtn.UseVisualStyleBackColor = false;
      closeBtn.Click += closeBtn_Click;
      // 
      // LeftPictureBox
      // 
      LeftPictureBox.Image = Properties.Resources.magical_library;
      LeftPictureBox.Location = new Point(0, 0);
      LeftPictureBox.Name = "LeftPictureBox";
      LeftPictureBox.Size = new Size(412, 600);
      LeftPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
      LeftPictureBox.TabIndex = 1;
      LeftPictureBox.TabStop = false;
      // 
      // UserLoginTitle
      // 
      UserLoginTitle.AutoSize = true;
      UserLoginTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
      UserLoginTitle.Location = new Point(466, 155);
      UserLoginTitle.Name = "UserLoginTitle";
      UserLoginTitle.Size = new Size(64, 28);
      UserLoginTitle.TabIndex = 2;
      UserLoginTitle.Text = "Login";
      // 
      // UsernameLabel
      // 
      UsernameLabel.AutoSize = true;
      UsernameLabel.Font = new Font("Segoe UI", 12F);
      UsernameLabel.Location = new Point(466, 202);
      UsernameLabel.Name = "UsernameLabel";
      UsernameLabel.Size = new Size(142, 21);
      UsernameLabel.TabIndex = 3;
      UsernameLabel.Text = "Email or Username";
      // 
      // UsernameTextBox
      // 
      UsernameTextBox.Font = new Font("Segoe UI", 12F);
      UsernameTextBox.Location = new Point(466, 233);
      UsernameTextBox.Name = "UsernameTextBox";
      UsernameTextBox.PlaceholderText = "Enter Email or Username";
      UsernameTextBox.Size = new Size(289, 29);
      UsernameTextBox.TabIndex = 1;
      // 
      // UserPasswordTextBox
      // 
      UserPasswordTextBox.Font = new Font("Segoe UI", 12F);
      UserPasswordTextBox.Location = new Point(466, 302);
      UserPasswordTextBox.Name = "UserPasswordTextBox";
      UserPasswordTextBox.PasswordChar = '*';
      UserPasswordTextBox.PlaceholderText = "Enter Password";
      UserPasswordTextBox.Size = new Size(289, 29);
      UserPasswordTextBox.TabIndex = 2;
      UserPasswordTextBox.KeyPress += UserPasswordTextBox_KeyPress;
      // 
      // UserPasswordLabel
      // 
      UserPasswordLabel.AutoSize = true;
      UserPasswordLabel.Font = new Font("Segoe UI", 12F);
      UserPasswordLabel.Location = new Point(466, 271);
      UserPasswordLabel.Name = "UserPasswordLabel";
      UserPasswordLabel.Size = new Size(76, 21);
      UserPasswordLabel.TabIndex = 5;
      UserPasswordLabel.Text = "Password";
      // 
      // UserLoginBtn
      // 
      UserLoginBtn.BackColor = Color.Green;
      UserLoginBtn.Cursor = Cursors.Hand;
      UserLoginBtn.FlatStyle = FlatStyle.Flat;
      UserLoginBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      UserLoginBtn.ForeColor = SystemColors.ControlLightLight;
      UserLoginBtn.Location = new Point(466, 379);
      UserLoginBtn.Name = "UserLoginBtn";
      UserLoginBtn.Size = new Size(289, 39);
      UserLoginBtn.TabIndex = 4;
      UserLoginBtn.Text = "Login";
      UserLoginBtn.UseVisualStyleBackColor = false;
      UserLoginBtn.Click += UserLoginBtn_Click;
      // 
      // UserShowPasswordCheckBox
      // 
      UserShowPasswordCheckBox.AutoSize = true;
      UserShowPasswordCheckBox.Cursor = Cursors.Hand;
      UserShowPasswordCheckBox.FlatAppearance.BorderSize = 0;
      UserShowPasswordCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      UserShowPasswordCheckBox.Location = new Point(466, 341);
      UserShowPasswordCheckBox.Name = "UserShowPasswordCheckBox";
      UserShowPasswordCheckBox.Size = new Size(112, 19);
      UserShowPasswordCheckBox.TabIndex = 3;
      UserShowPasswordCheckBox.Text = "Show Password";
      UserShowPasswordCheckBox.UseVisualStyleBackColor = true;
      UserShowPasswordCheckBox.CheckedChanged += UserShowPasswordCheckBox_CheckedChanged;
      // 
      // RegisterAccountLabel
      // 
      RegisterAccountLabel.AutoSize = true;
      RegisterAccountLabel.Cursor = Cursors.Hand;
      RegisterAccountLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      RegisterAccountLabel.Location = new Point(554, 430);
      RegisterAccountLabel.Name = "RegisterAccountLabel";
      RegisterAccountLabel.Size = new Size(122, 19);
      RegisterAccountLabel.TabIndex = 5;
      RegisterAccountLabel.Text = "Register Account";
      RegisterAccountLabel.Click += RegisterAccountLabel_Click;
      // 
      // LoginForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 600);
      Controls.Add(RegisterAccountLabel);
      Controls.Add(UserShowPasswordCheckBox);
      Controls.Add(UserLoginBtn);
      Controls.Add(UserPasswordTextBox);
      Controls.Add(UserPasswordLabel);
      Controls.Add(UsernameTextBox);
      Controls.Add(UsernameLabel);
      Controls.Add(UserLoginTitle);
      Controls.Add(LeftPictureBox);
      Controls.Add(TopPanel);
      Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      FormBorderStyle = FormBorderStyle.None;
      Name = "LoginForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "LoginForm";
      TopPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)LeftPictureBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel TopPanel;
    private Button closeBtn;
    private PictureBox LeftPictureBox;
    private Label UserLoginTitle;
    private Label UsernameLabel;
    private TextBox UsernameTextBox;
    private TextBox UserPasswordTextBox;
    private CheckBox UserShowPasswordCheckBox;
    private Label UserPasswordLabel;
    private Button UserLoginBtn;
    private Label RegisterAccountLabel;
  }
}