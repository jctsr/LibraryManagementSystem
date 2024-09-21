namespace LibraryManagementSystem
{
  partial class AdminMainForm
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
      DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
      TopPanel = new Panel();
      closeBtn = new Button();
      AdminPanel = new Custom_Controls.RoundedPanel();
      TitleLabel = new Label();
      UsernameLabel = new Label();
      WelcomeLabel = new Label();
      pictureBox1 = new PictureBox();
      LogOutBtn = new Button();
      AdminReturnBooksBtn = new Button();
      AdminIssueBooksBtn = new Button();
      AdminBooksBtn = new Button();
      AdminDashboardBtn = new Button();
      AdminDisplayPanel = new Custom_Controls.RoundedPanel();
      roundedPanel4 = new Custom_Controls.RoundedPanel();
      roundedPanel5 = new Custom_Controls.RoundedPanel();
      label1 = new Label();
      pictureBox2 = new PictureBox();
      label2 = new Label();
      roundedPanel6 = new Custom_Controls.RoundedPanel();
      label3 = new Label();
      pictureBox3 = new PictureBox();
      label4 = new Label();
      roundedPanel7 = new Custom_Controls.RoundedPanel();
      label5 = new Label();
      pictureBox4 = new PictureBox();
      label6 = new Label();
      roundedPanel3 = new Custom_Controls.RoundedPanel();
      TotalReturnedBooksLabel = new Label();
      ReturnedBooksPic = new PictureBox();
      ReturnedBooksLabel = new Label();
      roundedPanel2 = new Custom_Controls.RoundedPanel();
      TotalIssuedBooksLabel = new Label();
      IssuedBooksPic = new PictureBox();
      IssuedBooksLabel = new Label();
      roundedPanel1 = new Custom_Controls.RoundedPanel();
      TotalAvailableBooksLabel = new Label();
      AvailableBooksPic = new PictureBox();
      AvailableBooksLabel = new Label();
      AllBooksPanel = new Custom_Controls.RoundedPanel();
      roundedPanel9 = new Custom_Controls.RoundedPanel();
      ListOfBooksDataGridView = new DataGridView();
      Column1 = new DataGridViewTextBoxColumn();
      Column2 = new DataGridViewTextBoxColumn();
      Column3 = new DataGridViewTextBoxColumn();
      Column4 = new DataGridViewTextBoxColumn();
      Column5 = new DataGridViewTextBoxColumn();
      Column6 = new DataGridViewTextBoxColumn();
      ListOfAllBooksLabel = new Label();
      TopPanel.SuspendLayout();
      AdminPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      AdminDisplayPanel.SuspendLayout();
      roundedPanel4.SuspendLayout();
      roundedPanel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
      roundedPanel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
      roundedPanel7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
      roundedPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ReturnedBooksPic).BeginInit();
      roundedPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)IssuedBooksPic).BeginInit();
      roundedPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)AvailableBooksPic).BeginInit();
      AllBooksPanel.SuspendLayout();
      roundedPanel9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListOfBooksDataGridView).BeginInit();
      SuspendLayout();
      // 
      // TopPanel
      // 
      TopPanel.Controls.Add(closeBtn);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(0, 0);
      TopPanel.Name = "TopPanel";
      TopPanel.Size = new Size(1280, 40);
      TopPanel.TabIndex = 1;
      // 
      // closeBtn
      // 
      closeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      closeBtn.BackColor = SystemColors.Control;
      closeBtn.Cursor = Cursors.Hand;
      closeBtn.FlatAppearance.BorderColor = SystemColors.Control;
      closeBtn.FlatAppearance.BorderSize = 0;
      closeBtn.FlatAppearance.MouseDownBackColor = SystemColors.Control;
      closeBtn.FlatAppearance.MouseOverBackColor = SystemColors.Control;
      closeBtn.FlatStyle = FlatStyle.Flat;
      closeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      closeBtn.ForeColor = SystemColors.ControlText;
      closeBtn.Location = new Point(1212, 1);
      closeBtn.Name = "closeBtn";
      closeBtn.Size = new Size(68, 38);
      closeBtn.TabIndex = 8;
      closeBtn.TabStop = false;
      closeBtn.Text = "X";
      closeBtn.UseVisualStyleBackColor = false;
      closeBtn.Click += closeBtn_Click;
      // 
      // AdminPanel
      // 
      AdminPanel.BackColor = SystemColors.ButtonHighlight;
      AdminPanel.BorderRadius = 30;
      AdminPanel.Controls.Add(TitleLabel);
      AdminPanel.Controls.Add(UsernameLabel);
      AdminPanel.Controls.Add(WelcomeLabel);
      AdminPanel.Controls.Add(pictureBox1);
      AdminPanel.Controls.Add(LogOutBtn);
      AdminPanel.Controls.Add(AdminReturnBooksBtn);
      AdminPanel.Controls.Add(AdminIssueBooksBtn);
      AdminPanel.Controls.Add(AdminBooksBtn);
      AdminPanel.Controls.Add(AdminDashboardBtn);
      AdminPanel.Location = new Point(42, 61);
      AdminPanel.Name = "AdminPanel";
      AdminPanel.Size = new Size(341, 687);
      AdminPanel.TabIndex = 2;
      // 
      // TitleLabel
      // 
      TitleLabel.AutoSize = true;
      TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      TitleLabel.Location = new Point(69, 56);
      TitleLabel.Name = "TitleLabel";
      TitleLabel.Size = new Size(210, 21);
      TitleLabel.TabIndex = 3;
      TitleLabel.Text = "Library Management System";
      // 
      // UsernameLabel
      // 
      UsernameLabel.AutoSize = true;
      UsernameLabel.Font = new Font("Segoe UI", 12F);
      UsernameLabel.Location = new Point(180, 256);
      UsernameLabel.Name = "UsernameLabel";
      UsernameLabel.Size = new Size(74, 21);
      UsernameLabel.TabIndex = 10;
      UsernameLabel.Text = "Welcome";
      // 
      // WelcomeLabel
      // 
      WelcomeLabel.AutoSize = true;
      WelcomeLabel.Font = new Font("Segoe UI", 12F);
      WelcomeLabel.Location = new Point(101, 256);
      WelcomeLabel.Name = "WelcomeLabel";
      WelcomeLabel.Size = new Size(81, 21);
      WelcomeLabel.TabIndex = 9;
      WelcomeLabel.Text = "Welcome, ";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
      pictureBox1.Location = new Point(36, 92);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(269, 157);
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.TabIndex = 8;
      pictureBox1.TabStop = false;
      // 
      // LogOutBtn
      // 
      LogOutBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      LogOutBtn.BackColor = SystemColors.ButtonHighlight;
      LogOutBtn.Cursor = Cursors.Hand;
      LogOutBtn.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
      LogOutBtn.FlatAppearance.BorderSize = 0;
      LogOutBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
      LogOutBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
      LogOutBtn.FlatStyle = FlatStyle.Flat;
      LogOutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      LogOutBtn.ForeColor = SystemColors.ControlText;
      LogOutBtn.Image = Properties.Resources.logout;
      LogOutBtn.Location = new Point(36, 633);
      LogOutBtn.Name = "LogOutBtn";
      LogOutBtn.Padding = new Padding(1, 0, 0, 0);
      LogOutBtn.Size = new Size(48, 39);
      LogOutBtn.TabIndex = 7;
      LogOutBtn.UseVisualStyleBackColor = false;
      LogOutBtn.Click += LogOutBtn_Click;
      // 
      // AdminReturnBooksBtn
      // 
      AdminReturnBooksBtn.BackColor = Color.Green;
      AdminReturnBooksBtn.Cursor = Cursors.Hand;
      AdminReturnBooksBtn.FlatAppearance.BorderSize = 0;
      AdminReturnBooksBtn.FlatStyle = FlatStyle.Flat;
      AdminReturnBooksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      AdminReturnBooksBtn.ForeColor = SystemColors.ControlLightLight;
      AdminReturnBooksBtn.Image = Properties.Resources.book__1_;
      AdminReturnBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
      AdminReturnBooksBtn.Location = new Point(36, 484);
      AdminReturnBooksBtn.Name = "AdminReturnBooksBtn";
      AdminReturnBooksBtn.Padding = new Padding(10, 0, 0, 0);
      AdminReturnBooksBtn.Size = new Size(269, 39);
      AdminReturnBooksBtn.TabIndex = 6;
      AdminReturnBooksBtn.Text = "Return Books";
      AdminReturnBooksBtn.UseVisualStyleBackColor = false;
      AdminReturnBooksBtn.Click += AdminReturnBooksBtn_Click;
      // 
      // AdminIssueBooksBtn
      // 
      AdminIssueBooksBtn.BackColor = Color.Green;
      AdminIssueBooksBtn.Cursor = Cursors.Hand;
      AdminIssueBooksBtn.FlatAppearance.BorderSize = 0;
      AdminIssueBooksBtn.FlatStyle = FlatStyle.Flat;
      AdminIssueBooksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      AdminIssueBooksBtn.ForeColor = SystemColors.ControlLightLight;
      AdminIssueBooksBtn.Image = Properties.Resources.tracking;
      AdminIssueBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
      AdminIssueBooksBtn.Location = new Point(36, 420);
      AdminIssueBooksBtn.Name = "AdminIssueBooksBtn";
      AdminIssueBooksBtn.Padding = new Padding(10, 0, 0, 0);
      AdminIssueBooksBtn.Size = new Size(269, 39);
      AdminIssueBooksBtn.TabIndex = 5;
      AdminIssueBooksBtn.Text = "Issue Books";
      AdminIssueBooksBtn.UseVisualStyleBackColor = false;
      AdminIssueBooksBtn.Click += AdminIssueBooksBtn_Click;
      // 
      // AdminBooksBtn
      // 
      AdminBooksBtn.BackColor = Color.Green;
      AdminBooksBtn.Cursor = Cursors.Hand;
      AdminBooksBtn.FlatAppearance.BorderSize = 0;
      AdminBooksBtn.FlatStyle = FlatStyle.Flat;
      AdminBooksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      AdminBooksBtn.ForeColor = SystemColors.ControlLightLight;
      AdminBooksBtn.Image = Properties.Resources.book_stack;
      AdminBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
      AdminBooksBtn.Location = new Point(36, 356);
      AdminBooksBtn.Name = "AdminBooksBtn";
      AdminBooksBtn.Padding = new Padding(10, 0, 0, 0);
      AdminBooksBtn.Size = new Size(269, 39);
      AdminBooksBtn.TabIndex = 4;
      AdminBooksBtn.Text = "Books";
      AdminBooksBtn.UseVisualStyleBackColor = false;
      AdminBooksBtn.Click += AdminBooksBtn_Click;
      // 
      // AdminDashboardBtn
      // 
      AdminDashboardBtn.BackColor = Color.Green;
      AdminDashboardBtn.Cursor = Cursors.Hand;
      AdminDashboardBtn.FlatAppearance.BorderSize = 0;
      AdminDashboardBtn.FlatStyle = FlatStyle.Flat;
      AdminDashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      AdminDashboardBtn.ForeColor = SystemColors.ControlLightLight;
      AdminDashboardBtn.Image = Properties.Resources.dashboard__1_;
      AdminDashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
      AdminDashboardBtn.Location = new Point(36, 292);
      AdminDashboardBtn.Name = "AdminDashboardBtn";
      AdminDashboardBtn.Padding = new Padding(10, 0, 0, 0);
      AdminDashboardBtn.Size = new Size(269, 39);
      AdminDashboardBtn.TabIndex = 3;
      AdminDashboardBtn.Text = "Dashboard";
      AdminDashboardBtn.UseVisualStyleBackColor = false;
      AdminDashboardBtn.Click += AdminDashboardBtn_Click;
      // 
      // AdminDisplayPanel
      // 
      AdminDisplayPanel.BackColor = SystemColors.ButtonHighlight;
      AdminDisplayPanel.BorderRadius = 19;
      AdminDisplayPanel.Controls.Add(roundedPanel4);
      AdminDisplayPanel.Controls.Add(roundedPanel3);
      AdminDisplayPanel.Controls.Add(roundedPanel2);
      AdminDisplayPanel.Controls.Add(roundedPanel1);
      AdminDisplayPanel.Location = new Point(436, 61);
      AdminDisplayPanel.Name = "AdminDisplayPanel";
      AdminDisplayPanel.Size = new Size(800, 228);
      AdminDisplayPanel.TabIndex = 8;
      // 
      // roundedPanel4
      // 
      roundedPanel4.BackColor = SystemColors.ButtonHighlight;
      roundedPanel4.BorderRadius = 19;
      roundedPanel4.Controls.Add(roundedPanel5);
      roundedPanel4.Controls.Add(roundedPanel6);
      roundedPanel4.Controls.Add(roundedPanel7);
      roundedPanel4.Location = new Point(-3, 256);
      roundedPanel4.Name = "roundedPanel4";
      roundedPanel4.Size = new Size(800, 228);
      roundedPanel4.TabIndex = 11;
      // 
      // roundedPanel5
      // 
      roundedPanel5.BackColor = SystemColors.ControlLight;
      roundedPanel5.BorderRadius = 30;
      roundedPanel5.Controls.Add(label1);
      roundedPanel5.Controls.Add(pictureBox2);
      roundedPanel5.Controls.Add(label2);
      roundedPanel5.Location = new Point(558, 34);
      roundedPanel5.Name = "roundedPanel5";
      roundedPanel5.Size = new Size(221, 159);
      roundedPanel5.TabIndex = 10;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      label1.Location = new Point(180, 120);
      label1.Name = "label1";
      label1.Size = new Size(22, 25);
      label1.TabIndex = 4;
      label1.Text = "0";
      // 
      // pictureBox2
      // 
      pictureBox2.Image = Properties.Resources.download_icon_books_education_learning_library_page_paper_school_text_icon_1320166035140771246_512;
      pictureBox2.InitialImage = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_32;
      pictureBox2.Location = new Point(17, 55);
      pictureBox2.Name = "pictureBox2";
      pictureBox2.Size = new Size(74, 66);
      pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox2.TabIndex = 3;
      pictureBox2.TabStop = false;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.Location = new Point(72, 22);
      label2.Name = "label2";
      label2.Size = new Size(130, 21);
      label2.TabIndex = 2;
      label2.Text = "Returned Books";
      // 
      // roundedPanel6
      // 
      roundedPanel6.BackColor = SystemColors.ControlLight;
      roundedPanel6.BorderRadius = 30;
      roundedPanel6.Controls.Add(label3);
      roundedPanel6.Controls.Add(pictureBox3);
      roundedPanel6.Controls.Add(label4);
      roundedPanel6.Location = new Point(290, 34);
      roundedPanel6.Name = "roundedPanel6";
      roundedPanel6.Size = new Size(221, 159);
      roundedPanel6.TabIndex = 10;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      label3.Location = new Point(180, 120);
      label3.Name = "label3";
      label3.Size = new Size(22, 25);
      label3.TabIndex = 3;
      label3.Text = "0";
      // 
      // pictureBox3
      // 
      pictureBox3.Image = Properties.Resources.download_icon_library_books_24px_131985190355643637_512;
      pictureBox3.InitialImage = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_32;
      pictureBox3.Location = new Point(17, 55);
      pictureBox3.Name = "pictureBox3";
      pictureBox3.Size = new Size(74, 66);
      pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox3.TabIndex = 2;
      pictureBox3.TabStop = false;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label4.Location = new Point(72, 22);
      label4.Name = "label4";
      label4.Size = new Size(108, 21);
      label4.TabIndex = 1;
      label4.Text = "Issued Books";
      // 
      // roundedPanel7
      // 
      roundedPanel7.BackColor = SystemColors.ControlLight;
      roundedPanel7.BorderRadius = 30;
      roundedPanel7.Controls.Add(label5);
      roundedPanel7.Controls.Add(pictureBox4);
      roundedPanel7.Controls.Add(label6);
      roundedPanel7.Location = new Point(23, 34);
      roundedPanel7.Name = "roundedPanel7";
      roundedPanel7.Size = new Size(221, 159);
      roundedPanel7.TabIndex = 9;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      label5.Location = new Point(180, 120);
      label5.Name = "label5";
      label5.Size = new Size(22, 25);
      label5.TabIndex = 2;
      label5.Text = "0";
      // 
      // pictureBox4
      // 
      pictureBox4.Image = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_512;
      pictureBox4.InitialImage = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_32;
      pictureBox4.Location = new Point(17, 55);
      pictureBox4.Name = "pictureBox4";
      pictureBox4.Size = new Size(74, 66);
      pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox4.TabIndex = 1;
      pictureBox4.TabStop = false;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label6.Location = new Point(72, 22);
      label6.Name = "label6";
      label6.Size = new Size(132, 21);
      label6.TabIndex = 0;
      label6.Text = "Available Books";
      // 
      // roundedPanel3
      // 
      roundedPanel3.BackColor = SystemColors.ControlLight;
      roundedPanel3.BorderRadius = 30;
      roundedPanel3.Controls.Add(TotalReturnedBooksLabel);
      roundedPanel3.Controls.Add(ReturnedBooksPic);
      roundedPanel3.Controls.Add(ReturnedBooksLabel);
      roundedPanel3.Location = new Point(558, 34);
      roundedPanel3.Name = "roundedPanel3";
      roundedPanel3.Size = new Size(221, 159);
      roundedPanel3.TabIndex = 10;
      // 
      // TotalReturnedBooksLabel
      // 
      TotalReturnedBooksLabel.AutoSize = true;
      TotalReturnedBooksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      TotalReturnedBooksLabel.Location = new Point(180, 120);
      TotalReturnedBooksLabel.Name = "TotalReturnedBooksLabel";
      TotalReturnedBooksLabel.Size = new Size(22, 25);
      TotalReturnedBooksLabel.TabIndex = 4;
      TotalReturnedBooksLabel.Text = "0";
      // 
      // ReturnedBooksPic
      // 
      ReturnedBooksPic.Image = Properties.Resources.download_icon_books_education_learning_library_page_paper_school_text_icon_1320166035140771246_512;
      ReturnedBooksPic.InitialImage = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_32;
      ReturnedBooksPic.Location = new Point(17, 55);
      ReturnedBooksPic.Name = "ReturnedBooksPic";
      ReturnedBooksPic.Size = new Size(74, 66);
      ReturnedBooksPic.SizeMode = PictureBoxSizeMode.Zoom;
      ReturnedBooksPic.TabIndex = 3;
      ReturnedBooksPic.TabStop = false;
      // 
      // ReturnedBooksLabel
      // 
      ReturnedBooksLabel.AutoSize = true;
      ReturnedBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      ReturnedBooksLabel.Location = new Point(72, 22);
      ReturnedBooksLabel.Name = "ReturnedBooksLabel";
      ReturnedBooksLabel.Size = new Size(130, 21);
      ReturnedBooksLabel.TabIndex = 2;
      ReturnedBooksLabel.Text = "Returned Books";
      // 
      // roundedPanel2
      // 
      roundedPanel2.BackColor = SystemColors.ControlLight;
      roundedPanel2.BorderRadius = 30;
      roundedPanel2.Controls.Add(TotalIssuedBooksLabel);
      roundedPanel2.Controls.Add(IssuedBooksPic);
      roundedPanel2.Controls.Add(IssuedBooksLabel);
      roundedPanel2.Location = new Point(290, 34);
      roundedPanel2.Name = "roundedPanel2";
      roundedPanel2.Size = new Size(221, 159);
      roundedPanel2.TabIndex = 10;
      // 
      // TotalIssuedBooksLabel
      // 
      TotalIssuedBooksLabel.AutoSize = true;
      TotalIssuedBooksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      TotalIssuedBooksLabel.Location = new Point(180, 120);
      TotalIssuedBooksLabel.Name = "TotalIssuedBooksLabel";
      TotalIssuedBooksLabel.Size = new Size(22, 25);
      TotalIssuedBooksLabel.TabIndex = 3;
      TotalIssuedBooksLabel.Text = "0";
      // 
      // IssuedBooksPic
      // 
      IssuedBooksPic.Image = Properties.Resources.download_icon_library_books_24px_131985190355643637_512;
      IssuedBooksPic.InitialImage = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_32;
      IssuedBooksPic.Location = new Point(17, 55);
      IssuedBooksPic.Name = "IssuedBooksPic";
      IssuedBooksPic.Size = new Size(74, 66);
      IssuedBooksPic.SizeMode = PictureBoxSizeMode.Zoom;
      IssuedBooksPic.TabIndex = 2;
      IssuedBooksPic.TabStop = false;
      // 
      // IssuedBooksLabel
      // 
      IssuedBooksLabel.AutoSize = true;
      IssuedBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      IssuedBooksLabel.Location = new Point(72, 22);
      IssuedBooksLabel.Name = "IssuedBooksLabel";
      IssuedBooksLabel.Size = new Size(108, 21);
      IssuedBooksLabel.TabIndex = 1;
      IssuedBooksLabel.Text = "Issued Books";
      // 
      // roundedPanel1
      // 
      roundedPanel1.BackColor = SystemColors.ControlLight;
      roundedPanel1.BorderRadius = 30;
      roundedPanel1.Controls.Add(TotalAvailableBooksLabel);
      roundedPanel1.Controls.Add(AvailableBooksPic);
      roundedPanel1.Controls.Add(AvailableBooksLabel);
      roundedPanel1.Location = new Point(23, 34);
      roundedPanel1.Name = "roundedPanel1";
      roundedPanel1.Size = new Size(221, 159);
      roundedPanel1.TabIndex = 9;
      // 
      // TotalAvailableBooksLabel
      // 
      TotalAvailableBooksLabel.AutoSize = true;
      TotalAvailableBooksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      TotalAvailableBooksLabel.Location = new Point(180, 120);
      TotalAvailableBooksLabel.Name = "TotalAvailableBooksLabel";
      TotalAvailableBooksLabel.Size = new Size(22, 25);
      TotalAvailableBooksLabel.TabIndex = 2;
      TotalAvailableBooksLabel.Text = "0";
      // 
      // AvailableBooksPic
      // 
      AvailableBooksPic.Image = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_512;
      AvailableBooksPic.InitialImage = Properties.Resources.download_icon_books_college_education_knowledge_learning_library_office_read_1320166034987769818_32;
      AvailableBooksPic.Location = new Point(17, 55);
      AvailableBooksPic.Name = "AvailableBooksPic";
      AvailableBooksPic.Size = new Size(74, 66);
      AvailableBooksPic.SizeMode = PictureBoxSizeMode.Zoom;
      AvailableBooksPic.TabIndex = 1;
      AvailableBooksPic.TabStop = false;
      // 
      // AvailableBooksLabel
      // 
      AvailableBooksLabel.AutoSize = true;
      AvailableBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      AvailableBooksLabel.Location = new Point(72, 22);
      AvailableBooksLabel.Name = "AvailableBooksLabel";
      AvailableBooksLabel.Size = new Size(132, 21);
      AvailableBooksLabel.TabIndex = 0;
      AvailableBooksLabel.Text = "Available Books";
      // 
      // AllBooksPanel
      // 
      AllBooksPanel.BackColor = SystemColors.ButtonHighlight;
      AllBooksPanel.BorderRadius = 19;
      AllBooksPanel.Controls.Add(roundedPanel9);
      AllBooksPanel.Location = new Point(436, 314);
      AllBooksPanel.Name = "AllBooksPanel";
      AllBooksPanel.Size = new Size(800, 434);
      AllBooksPanel.TabIndex = 12;
      // 
      // roundedPanel9
      // 
      roundedPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      roundedPanel9.BackColor = SystemColors.Control;
      roundedPanel9.BorderRadius = 30;
      roundedPanel9.Controls.Add(ListOfBooksDataGridView);
      roundedPanel9.Controls.Add(ListOfAllBooksLabel);
      roundedPanel9.Location = new Point(23, 37);
      roundedPanel9.Name = "roundedPanel9";
      roundedPanel9.Size = new Size(756, 360);
      roundedPanel9.TabIndex = 25;
      // 
      // ListOfBooksDataGridView
      // 
      ListOfBooksDataGridView.AllowUserToAddRows = false;
      ListOfBooksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      ListOfBooksDataGridView.BackgroundColor = SystemColors.Control;
      ListOfBooksDataGridView.BorderStyle = BorderStyle.None;
      ListOfBooksDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = Color.Green;
      dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      dataGridViewCellStyle3.ForeColor = Color.White;
      dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      ListOfBooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      ListOfBooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ListOfBooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
      dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
      dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
      dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
      ListOfBooksDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
      ListOfBooksDataGridView.EnableHeadersVisualStyles = false;
      ListOfBooksDataGridView.GridColor = SystemColors.ControlLight;
      ListOfBooksDataGridView.Location = new Point(0, 33);
      ListOfBooksDataGridView.Name = "ListOfBooksDataGridView";
      ListOfBooksDataGridView.ReadOnly = true;
      ListOfBooksDataGridView.RowHeadersVisible = false;
      ListOfBooksDataGridView.RowTemplate.Height = 30;
      ListOfBooksDataGridView.Size = new Size(756, 313);
      ListOfBooksDataGridView.TabIndex = 1;
      // 
      // Column1
      // 
      Column1.DataPropertyName = "Id";
      Column1.FillWeight = 24.08629F;
      Column1.HeaderText = "ID";
      Column1.MinimumWidth = 3;
      Column1.Name = "Column1";
      Column1.ReadOnly = true;
      // 
      // Column2
      // 
      Column2.DataPropertyName = "Title";
      Column2.FillWeight = 59.08629F;
      Column2.HeaderText = "Title";
      Column2.Name = "Column2";
      Column2.ReadOnly = true;
      // 
      // Column3
      // 
      Column3.DataPropertyName = "Author";
      Column3.FillWeight = 59.08629F;
      Column3.HeaderText = "Author";
      Column3.Name = "Column3";
      Column3.ReadOnly = true;
      // 
      // Column4
      // 
      Column4.DataPropertyName = "Published_Date";
      Column4.FillWeight = 59.08629F;
      Column4.HeaderText = "Published";
      Column4.Name = "Column4";
      Column4.ReadOnly = true;
      // 
      // Column5
      // 
      Column5.DataPropertyName = "Status";
      Column5.FillWeight = 38.08629F;
      Column5.HeaderText = "Status";
      Column5.Name = "Column5";
      Column5.ReadOnly = true;
      // 
      // Column6
      // 
      Column6.DataPropertyName = "Image";
      Column6.FillWeight = 59.08629F;
      Column6.HeaderText = "Image";
      Column6.Name = "Column6";
      Column6.ReadOnly = true;
      // 
      // ListOfAllBooksLabel
      // 
      ListOfAllBooksLabel.AutoSize = true;
      ListOfAllBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      ListOfAllBooksLabel.Location = new Point(24, 5);
      ListOfAllBooksLabel.Name = "ListOfAllBooksLabel";
      ListOfAllBooksLabel.Size = new Size(85, 21);
      ListOfAllBooksLabel.TabIndex = 0;
      ListOfAllBooksLabel.Text = "All Books:";
      // 
      // AdminMainForm
      // 
      AutoScaleDimensions = new SizeF(96F, 96F);
      AutoScaleMode = AutoScaleMode.Dpi;
      BackColor = SystemColors.Control;
      ClientSize = new Size(1280, 800);
      Controls.Add(AllBooksPanel);
      Controls.Add(AdminDisplayPanel);
      Controls.Add(AdminPanel);
      Controls.Add(TopPanel);
      FormBorderStyle = FormBorderStyle.None;
      Name = "AdminMainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "AdminMainForm";
      TopPanel.ResumeLayout(false);
      AdminPanel.ResumeLayout(false);
      AdminPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      AdminDisplayPanel.ResumeLayout(false);
      roundedPanel4.ResumeLayout(false);
      roundedPanel5.ResumeLayout(false);
      roundedPanel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
      roundedPanel6.ResumeLayout(false);
      roundedPanel6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
      roundedPanel7.ResumeLayout(false);
      roundedPanel7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
      roundedPanel3.ResumeLayout(false);
      roundedPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ReturnedBooksPic).EndInit();
      roundedPanel2.ResumeLayout(false);
      roundedPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)IssuedBooksPic).EndInit();
      roundedPanel1.ResumeLayout(false);
      roundedPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)AvailableBooksPic).EndInit();
      AllBooksPanel.ResumeLayout(false);
      roundedPanel9.ResumeLayout(false);
      roundedPanel9.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ListOfBooksDataGridView).EndInit();
      ResumeLayout(false);
    }

    #endregion
    private Panel TopPanel;
    private Button closeBtn;
    private Custom_Controls.RoundedPanel AdminPanel;
    private Button AdminDashboardBtn;
    private Button AdminBooksBtn;
    private Button AdminIssueBooksBtn;
    private Button AdminReturnBooksBtn;
    private Button LogOutBtn;
    private Custom_Controls.RoundedPanel AdminDisplayPanel;
    private Custom_Controls.RoundedPanel roundedPanel3;
    private Custom_Controls.RoundedPanel roundedPanel2;
    private Custom_Controls.RoundedPanel roundedPanel1;
    private Label AvailableBooksLabel;
    private Label ReturnedBooksLabel;
    private Label IssuedBooksLabel;
    private PictureBox AvailableBooksPic;
    private PictureBox ReturnedBooksPic;
    private PictureBox IssuedBooksPic;
    private Label TotalReturnedBooksLabel;
    private Label TotalIssuedBooksLabel;
    private Label TotalAvailableBooksLabel;
    private PictureBox pictureBox1;
    private Label WelcomeLabel;
    private Label UsernameLabel;
    private Label TitleLabel;
    private Custom_Controls.RoundedPanel roundedPanel4;
    private Custom_Controls.RoundedPanel roundedPanel5;
    private Label label1;
    private PictureBox pictureBox2;
    private Label label2;
    private Custom_Controls.RoundedPanel roundedPanel6;
    private Label label3;
    private PictureBox pictureBox3;
    private Label label4;
    private Custom_Controls.RoundedPanel roundedPanel7;
    private Label label5;
    private PictureBox pictureBox4;
    private Label label6;
    private Custom_Controls.RoundedPanel AllBooksPanel;
    private Custom_Controls.RoundedPanel roundedPanel9;
    private DataGridView ListOfBooksDataGridView;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private Label ListOfAllBooksLabel;
  }
}