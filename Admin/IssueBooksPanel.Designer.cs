namespace LibraryManagementSystem
{
  partial class IssueBooksPanel
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
      roundedPanel2 = new Custom_Controls.RoundedPanel();
      ListOfBooksDataGridView = new DataGridView();
      Column1 = new DataGridViewTextBoxColumn();
      Column7 = new DataGridViewTextBoxColumn();
      Column9 = new DataGridViewTextBoxColumn();
      Column8 = new DataGridViewTextBoxColumn();
      Column2 = new DataGridViewTextBoxColumn();
      Column3 = new DataGridViewTextBoxColumn();
      Column4 = new DataGridViewTextBoxColumn();
      Column5 = new DataGridViewTextBoxColumn();
      ListOfIssuedBooksLabel = new Label();
      roundedPanel1 = new Custom_Controls.RoundedPanel();
      BooksPic = new PictureBox();
      TitleComboBox = new ComboBox();
      AuthorLabel = new Label();
      AuthorTextBox = new TextBox();
      TitleLabel = new Label();
      EmailLabel = new Label();
      label1 = new Label();
      EmailTextBox = new TextBox();
      ClearBtn = new Button();
      DeleteBtn = new Button();
      UpdateBtn = new Button();
      IssueStatusComboBox = new ComboBox();
      AddBtn = new Button();
      StatusLabel = new Label();
      IssueDateTimePicker = new DateTimePicker();
      IssueDateLabel = new Label();
      PhoneNumberLabel = new Label();
      ContactNumberTextBox = new TextBox();
      NameLabel = new Label();
      NameTextBox = new TextBox();
      TotalAvailableBooksLabel = new Label();
      roundedPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListOfBooksDataGridView).BeginInit();
      roundedPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)BooksPic).BeginInit();
      SuspendLayout();
      // 
      // roundedPanel2
      // 
      roundedPanel2.BackColor = SystemColors.Control;
      roundedPanel2.BorderRadius = 30;
      roundedPanel2.Controls.Add(ListOfBooksDataGridView);
      roundedPanel2.Controls.Add(ListOfIssuedBooksLabel);
      roundedPanel2.Location = new Point(38, 34);
      roundedPanel2.Name = "roundedPanel2";
      roundedPanel2.Size = new Size(722, 342);
      roundedPanel2.TabIndex = 25;
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
      ListOfBooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column9, Column8, Column2, Column3, Column4, Column5 });
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
      ListOfBooksDataGridView.Size = new Size(722, 275);
      ListOfBooksDataGridView.TabIndex = 1;
      ListOfBooksDataGridView.CellClick += ListOfBooksDataGridView_CellClick;
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
      // Column7
      // 
      Column7.DataPropertyName = "Name";
      Column7.FillWeight = 50F;
      Column7.HeaderText = "Name";
      Column7.Name = "Column7";
      Column7.ReadOnly = true;
      // 
      // Column9
      // 
      Column9.DataPropertyName = "Email";
      Column9.FillWeight = 60F;
      Column9.HeaderText = "Email";
      Column9.Name = "Column9";
      Column9.ReadOnly = true;
      // 
      // Column8
      // 
      Column8.DataPropertyName = "Contact";
      Column8.FillWeight = 50F;
      Column8.HeaderText = "Phone";
      Column8.Name = "Column8";
      Column8.ReadOnly = true;
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
      Column4.DataPropertyName = "Issued_Date";
      Column4.FillWeight = 59.08629F;
      Column4.HeaderText = "Issued";
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
      // ListOfIssuedBooksLabel
      // 
      ListOfIssuedBooksLabel.AutoSize = true;
      ListOfIssuedBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      ListOfIssuedBooksLabel.Location = new Point(24, 5);
      ListOfIssuedBooksLabel.Name = "ListOfIssuedBooksLabel";
      ListOfIssuedBooksLabel.Size = new Size(162, 21);
      ListOfIssuedBooksLabel.TabIndex = 0;
      ListOfIssuedBooksLabel.Text = "List of Issued books:";
      // 
      // roundedPanel1
      // 
      roundedPanel1.BackColor = SystemColors.Control;
      roundedPanel1.BorderRadius = 30;
      roundedPanel1.Controls.Add(BooksPic);
      roundedPanel1.Controls.Add(TitleComboBox);
      roundedPanel1.Controls.Add(AuthorLabel);
      roundedPanel1.Controls.Add(AuthorTextBox);
      roundedPanel1.Controls.Add(TitleLabel);
      roundedPanel1.Controls.Add(EmailLabel);
      roundedPanel1.Controls.Add(label1);
      roundedPanel1.Controls.Add(EmailTextBox);
      roundedPanel1.Controls.Add(ClearBtn);
      roundedPanel1.Controls.Add(DeleteBtn);
      roundedPanel1.Controls.Add(UpdateBtn);
      roundedPanel1.Controls.Add(IssueStatusComboBox);
      roundedPanel1.Controls.Add(AddBtn);
      roundedPanel1.Controls.Add(StatusLabel);
      roundedPanel1.Controls.Add(IssueDateTimePicker);
      roundedPanel1.Controls.Add(IssueDateLabel);
      roundedPanel1.Controls.Add(PhoneNumberLabel);
      roundedPanel1.Controls.Add(ContactNumberTextBox);
      roundedPanel1.Controls.Add(NameLabel);
      roundedPanel1.Controls.Add(NameTextBox);
      roundedPanel1.Controls.Add(TotalAvailableBooksLabel);
      roundedPanel1.Location = new Point(38, 406);
      roundedPanel1.Name = "roundedPanel1";
      roundedPanel1.Size = new Size(722, 252);
      roundedPanel1.TabIndex = 26;
      // 
      // BooksPic
      // 
      BooksPic.BackColor = SystemColors.Window;
      BooksPic.Location = new Point(349, 96);
      BooksPic.Name = "BooksPic";
      BooksPic.Size = new Size(135, 118);
      BooksPic.SizeMode = PictureBoxSizeMode.Zoom;
      BooksPic.TabIndex = 36;
      BooksPic.TabStop = false;
      // 
      // TitleComboBox
      // 
      TitleComboBox.FormattingEnabled = true;
      TitleComboBox.Items.AddRange(new object[] { "Issued", "Returned" });
      TitleComboBox.Location = new Point(349, 18);
      TitleComboBox.Name = "TitleComboBox";
      TitleComboBox.Size = new Size(135, 23);
      TitleComboBox.TabIndex = 6;
      TitleComboBox.SelectedIndexChanged += TitleComboBox_SelectedIndexChanged;
      // 
      // AuthorLabel
      // 
      AuthorLabel.AutoSize = true;
      AuthorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      AuthorLabel.Location = new Point(294, 59);
      AuthorLabel.Name = "AuthorLabel";
      AuthorLabel.Size = new Size(49, 15);
      AuthorLabel.TabIndex = 34;
      AuthorLabel.Text = "Author:";
      // 
      // AuthorTextBox
      // 
      AuthorTextBox.BackColor = SystemColors.Control;
      AuthorTextBox.BorderStyle = BorderStyle.None;
      AuthorTextBox.Location = new Point(349, 60);
      AuthorTextBox.Name = "AuthorTextBox";
      AuthorTextBox.Size = new Size(135, 16);
      AuthorTextBox.TabIndex = 33;
      // 
      // TitleLabel
      // 
      TitleLabel.AutoSize = true;
      TitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      TitleLabel.Location = new Point(308, 21);
      TitleLabel.Name = "TitleLabel";
      TitleLabel.Size = new Size(35, 15);
      TitleLabel.TabIndex = 32;
      TitleLabel.Text = "Title:";
      // 
      // EmailLabel
      // 
      EmailLabel.AutoSize = true;
      EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      EmailLabel.Location = new Point(36, 97);
      EmailLabel.Name = "EmailLabel";
      EmailLabel.Size = new Size(39, 15);
      EmailLabel.TabIndex = 28;
      EmailLabel.Text = "Email:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      label1.Location = new Point(43, 96);
      label1.Name = "label1";
      label1.Size = new Size(0, 15);
      label1.TabIndex = 27;
      // 
      // EmailTextBox
      // 
      EmailTextBox.Location = new Point(81, 94);
      EmailTextBox.Name = "EmailTextBox";
      EmailTextBox.Size = new Size(160, 23);
      EmailTextBox.TabIndex = 3;
      // 
      // ClearBtn
      // 
      ClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ClearBtn.BackColor = Color.Green;
      ClearBtn.Cursor = Cursors.Hand;
      ClearBtn.FlatAppearance.BorderColor = Color.Green;
      ClearBtn.FlatAppearance.BorderSize = 0;
      ClearBtn.FlatAppearance.MouseDownBackColor = Color.Green;
      ClearBtn.FlatAppearance.MouseOverBackColor = Color.Green;
      ClearBtn.FlatStyle = FlatStyle.Flat;
      ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      ClearBtn.ForeColor = SystemColors.ControlLightLight;
      ClearBtn.Location = new Point(528, 192);
      ClearBtn.Name = "ClearBtn";
      ClearBtn.Size = new Size(150, 39);
      ClearBtn.TabIndex = 10;
      ClearBtn.Text = "Clear";
      ClearBtn.UseVisualStyleBackColor = false;
      ClearBtn.Click += ClearBtn_Click;
      // 
      // DeleteBtn
      // 
      DeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      DeleteBtn.BackColor = Color.Green;
      DeleteBtn.Cursor = Cursors.Hand;
      DeleteBtn.FlatAppearance.BorderColor = Color.Green;
      DeleteBtn.FlatAppearance.BorderSize = 0;
      DeleteBtn.FlatAppearance.MouseDownBackColor = Color.Green;
      DeleteBtn.FlatAppearance.MouseOverBackColor = Color.Green;
      DeleteBtn.FlatStyle = FlatStyle.Flat;
      DeleteBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      DeleteBtn.ForeColor = SystemColors.ControlLightLight;
      DeleteBtn.Location = new Point(528, 133);
      DeleteBtn.Name = "DeleteBtn";
      DeleteBtn.Size = new Size(150, 39);
      DeleteBtn.TabIndex = 9;
      DeleteBtn.Text = "Delete";
      DeleteBtn.UseVisualStyleBackColor = false;
      DeleteBtn.Click += DeleteBtn_Click;
      // 
      // UpdateBtn
      // 
      UpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      UpdateBtn.BackColor = Color.Green;
      UpdateBtn.Cursor = Cursors.Hand;
      UpdateBtn.FlatAppearance.BorderColor = Color.Green;
      UpdateBtn.FlatAppearance.BorderSize = 0;
      UpdateBtn.FlatAppearance.MouseDownBackColor = Color.Green;
      UpdateBtn.FlatAppearance.MouseOverBackColor = Color.Green;
      UpdateBtn.FlatStyle = FlatStyle.Flat;
      UpdateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      UpdateBtn.ForeColor = SystemColors.ControlLightLight;
      UpdateBtn.Location = new Point(528, 74);
      UpdateBtn.Name = "UpdateBtn";
      UpdateBtn.Size = new Size(150, 39);
      UpdateBtn.TabIndex = 8;
      UpdateBtn.Text = "Update";
      UpdateBtn.UseVisualStyleBackColor = false;
      UpdateBtn.Click += UpdateBtn_Click;
      // 
      // IssueStatusComboBox
      // 
      IssueStatusComboBox.FormattingEnabled = true;
      IssueStatusComboBox.ItemHeight = 15;
      IssueStatusComboBox.Items.AddRange(new object[] { "Issued", "Returned" });
      IssueStatusComboBox.Location = new Point(81, 170);
      IssueStatusComboBox.Name = "IssueStatusComboBox";
      IssueStatusComboBox.Size = new Size(160, 23);
      IssueStatusComboBox.TabIndex = 5;
      // 
      // AddBtn
      // 
      AddBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      AddBtn.BackColor = Color.Green;
      AddBtn.Cursor = Cursors.Hand;
      AddBtn.FlatAppearance.BorderColor = Color.Green;
      AddBtn.FlatAppearance.BorderSize = 0;
      AddBtn.FlatAppearance.MouseDownBackColor = Color.Green;
      AddBtn.FlatAppearance.MouseOverBackColor = Color.Green;
      AddBtn.FlatStyle = FlatStyle.Flat;
      AddBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      AddBtn.ForeColor = SystemColors.ControlLightLight;
      AddBtn.Location = new Point(528, 15);
      AddBtn.Name = "AddBtn";
      AddBtn.Size = new Size(150, 39);
      AddBtn.TabIndex = 7;
      AddBtn.Text = "Add";
      AddBtn.UseVisualStyleBackColor = false;
      AddBtn.Click += AddBtn_Click;
      // 
      // StatusLabel
      // 
      StatusLabel.AutoSize = true;
      StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      StatusLabel.Location = new Point(30, 173);
      StatusLabel.Name = "StatusLabel";
      StatusLabel.Size = new Size(45, 15);
      StatusLabel.TabIndex = 20;
      StatusLabel.Text = "Status:";
      // 
      // IssueDateTimePicker
      // 
      IssueDateTimePicker.Location = new Point(81, 132);
      IssueDateTimePicker.Name = "IssueDateTimePicker";
      IssueDateTimePicker.Size = new Size(200, 23);
      IssueDateTimePicker.TabIndex = 4;
      // 
      // IssueDateLabel
      // 
      IssueDateLabel.AutoSize = true;
      IssueDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      IssueDateLabel.Location = new Point(37, 135);
      IssueDateLabel.Name = "IssueDateLabel";
      IssueDateLabel.Size = new Size(38, 15);
      IssueDateLabel.TabIndex = 18;
      IssueDateLabel.Text = "Issue:";
      // 
      // PhoneNumberLabel
      // 
      PhoneNumberLabel.AutoSize = true;
      PhoneNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      PhoneNumberLabel.Location = new Point(30, 59);
      PhoneNumberLabel.Name = "PhoneNumberLabel";
      PhoneNumberLabel.Size = new Size(45, 15);
      PhoneNumberLabel.TabIndex = 16;
      PhoneNumberLabel.Text = "Phone:";
      // 
      // ContactNumberTextBox
      // 
      ContactNumberTextBox.Location = new Point(81, 56);
      ContactNumberTextBox.Name = "ContactNumberTextBox";
      ContactNumberTextBox.PlaceholderText = "e.g. 0142345562";
      ContactNumberTextBox.Size = new Size(160, 23);
      ContactNumberTextBox.TabIndex = 2;
      // 
      // NameLabel
      // 
      NameLabel.AutoSize = true;
      NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      NameLabel.Location = new Point(32, 21);
      NameLabel.Name = "NameLabel";
      NameLabel.Size = new Size(43, 15);
      NameLabel.TabIndex = 14;
      NameLabel.Text = "Name:";
      // 
      // NameTextBox
      // 
      NameTextBox.Location = new Point(81, 18);
      NameTextBox.Name = "NameTextBox";
      NameTextBox.Size = new Size(160, 23);
      NameTextBox.TabIndex = 1;
      // 
      // TotalAvailableBooksLabel
      // 
      TotalAvailableBooksLabel.AutoSize = true;
      TotalAvailableBooksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      TotalAvailableBooksLabel.Location = new Point(182, 147);
      TotalAvailableBooksLabel.Name = "TotalAvailableBooksLabel";
      TotalAvailableBooksLabel.Size = new Size(0, 25);
      TotalAvailableBooksLabel.TabIndex = 2;
      // 
      // IssueBooksPanel
      // 
      AutoScaleDimensions = new SizeF(96F, 96F);
      AutoScaleMode = AutoScaleMode.Dpi;
      BackColor = SystemColors.ButtonHighlight;
      Controls.Add(roundedPanel1);
      Controls.Add(roundedPanel2);
      Name = "IssueBooksPanel";
      Size = new Size(800, 687);
      roundedPanel2.ResumeLayout(false);
      roundedPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ListOfBooksDataGridView).EndInit();
      roundedPanel1.ResumeLayout(false);
      roundedPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)BooksPic).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Custom_Controls.RoundedPanel roundedPanel2;
    private DataGridView ListOfBooksDataGridView;
    private Label ListOfIssuedBooksLabel;
    private Custom_Controls.RoundedPanel roundedPanel1;
    private Button ClearBtn;
    private Button DeleteBtn;
    private Button UpdateBtn;
    private ComboBox IssueStatusComboBox;
    private Button AddBtn;
    private Label StatusLabel;
    private DateTimePicker IssueDateTimePicker;
    private Label IssueDateLabel;
    private Label PhoneNumberLabel;
    private TextBox ContactNumberTextBox;
    private Label NameLabel;
    private TextBox NameTextBox;
    private Label TotalAvailableBooksLabel;
    private Label label1;
    private TextBox EmailTextBox;
    private Label EmailLabel;
    private Label AuthorLabel;
    private TextBox AuthorTextBox;
    private Label TitleLabel;
    private ComboBox TitleComboBox;
    private PictureBox BooksPic;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column9;
    private DataGridViewTextBoxColumn Column8;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
  }
}
