namespace LibraryManagementSystem
{
  partial class ManageBooksPanel
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
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
      roundedPanel1 = new Custom_Controls.RoundedPanel();
      ClearBtn = new Button();
      ImportImageBtn = new Button();
      DeleteBtn = new Button();
      UpdateBtn = new Button();
      AddStatusBooksComboBox = new ComboBox();
      AddBtn = new Button();
      StatusLabel = new Label();
      AddPublishedDateTImePicker = new DateTimePicker();
      PublishedLabel = new Label();
      AuthorLabel = new Label();
      AddAuthorTextBox = new TextBox();
      TitleLabel = new Label();
      AddTitleTextBox = new TextBox();
      BooksPic = new PictureBox();
      TotalAvailableBooksLabel = new Label();
      roundedPanel2 = new Custom_Controls.RoundedPanel();
      ListOfBooksDataGridView = new DataGridView();
      Column1 = new DataGridViewTextBoxColumn();
      Column2 = new DataGridViewTextBoxColumn();
      Column3 = new DataGridViewTextBoxColumn();
      Column4 = new DataGridViewTextBoxColumn();
      Column5 = new DataGridViewTextBoxColumn();
      Column6 = new DataGridViewTextBoxColumn();
      ListOfBooksLabel = new Label();
      roundedPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)BooksPic).BeginInit();
      roundedPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListOfBooksDataGridView).BeginInit();
      SuspendLayout();
      // 
      // roundedPanel1
      // 
      roundedPanel1.BackColor = SystemColors.Control;
      roundedPanel1.BorderRadius = 30;
      roundedPanel1.Controls.Add(ClearBtn);
      roundedPanel1.Controls.Add(ImportImageBtn);
      roundedPanel1.Controls.Add(DeleteBtn);
      roundedPanel1.Controls.Add(UpdateBtn);
      roundedPanel1.Controls.Add(AddStatusBooksComboBox);
      roundedPanel1.Controls.Add(AddBtn);
      roundedPanel1.Controls.Add(StatusLabel);
      roundedPanel1.Controls.Add(AddPublishedDateTImePicker);
      roundedPanel1.Controls.Add(PublishedLabel);
      roundedPanel1.Controls.Add(AuthorLabel);
      roundedPanel1.Controls.Add(AddAuthorTextBox);
      roundedPanel1.Controls.Add(TitleLabel);
      roundedPanel1.Controls.Add(AddTitleTextBox);
      roundedPanel1.Controls.Add(BooksPic);
      roundedPanel1.Controls.Add(TotalAvailableBooksLabel);
      roundedPanel1.Location = new Point(38, 406);
      roundedPanel1.Name = "roundedPanel1";
      roundedPanel1.Size = new Size(722, 252);
      roundedPanel1.TabIndex = 10;
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
      ClearBtn.TabIndex = 9;
      ClearBtn.Text = "Clear";
      ClearBtn.UseVisualStyleBackColor = false;
      ClearBtn.Click += ClearBtn_Click;
      // 
      // ImportImageBtn
      // 
      ImportImageBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ImportImageBtn.BackColor = Color.Green;
      ImportImageBtn.Cursor = Cursors.Hand;
      ImportImageBtn.FlatAppearance.BorderColor = Color.Green;
      ImportImageBtn.FlatAppearance.BorderSize = 0;
      ImportImageBtn.FlatAppearance.MouseDownBackColor = Color.Green;
      ImportImageBtn.FlatAppearance.MouseOverBackColor = Color.Green;
      ImportImageBtn.FlatStyle = FlatStyle.Flat;
      ImportImageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      ImportImageBtn.ForeColor = SystemColors.ControlLightLight;
      ImportImageBtn.Location = new Point(337, 153);
      ImportImageBtn.Name = "ImportImageBtn";
      ImportImageBtn.Size = new Size(135, 39);
      ImportImageBtn.TabIndex = 5;
      ImportImageBtn.Text = "Import Image";
      ImportImageBtn.UseVisualStyleBackColor = false;
      ImportImageBtn.Click += ImportImageBtn_Click;
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
      DeleteBtn.TabIndex = 8;
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
      UpdateBtn.TabIndex = 7;
      UpdateBtn.Text = "Update";
      UpdateBtn.UseVisualStyleBackColor = false;
      UpdateBtn.Click += UpdateBtn_Click;
      // 
      // AddStatusBooksComboBox
      // 
      AddStatusBooksComboBox.FormattingEnabled = true;
      AddStatusBooksComboBox.Items.AddRange(new object[] { "Available", "Not Available" });
      AddStatusBooksComboBox.Location = new Point(79, 156);
      AddStatusBooksComboBox.Name = "AddStatusBooksComboBox";
      AddStatusBooksComboBox.Size = new Size(121, 23);
      AddStatusBooksComboBox.TabIndex = 4;
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
      AddBtn.TabIndex = 6;
      AddBtn.Text = "Add";
      AddBtn.UseVisualStyleBackColor = false;
      AddBtn.Click += AddBtn_Click;
      // 
      // StatusLabel
      // 
      StatusLabel.AutoSize = true;
      StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      StatusLabel.Location = new Point(28, 159);
      StatusLabel.Name = "StatusLabel";
      StatusLabel.Size = new Size(45, 15);
      StatusLabel.TabIndex = 20;
      StatusLabel.Text = "Status:";
      // 
      // AddPublishedDateTImePicker
      // 
      AddPublishedDateTImePicker.Location = new Point(79, 113);
      AddPublishedDateTImePicker.Name = "AddPublishedDateTImePicker";
      AddPublishedDateTImePicker.Size = new Size(200, 23);
      AddPublishedDateTImePicker.TabIndex = 3;
      // 
      // PublishedLabel
      // 
      PublishedLabel.AutoSize = true;
      PublishedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      PublishedLabel.Location = new Point(10, 119);
      PublishedLabel.Name = "PublishedLabel";
      PublishedLabel.Size = new Size(63, 15);
      PublishedLabel.TabIndex = 18;
      PublishedLabel.Text = "Published:";
      // 
      // AuthorLabel
      // 
      AuthorLabel.AutoSize = true;
      AuthorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      AuthorLabel.Location = new Point(24, 74);
      AuthorLabel.Name = "AuthorLabel";
      AuthorLabel.Size = new Size(49, 15);
      AuthorLabel.TabIndex = 16;
      AuthorLabel.Text = "Author:";
      // 
      // AddAuthorTextBox
      // 
      AddAuthorTextBox.Location = new Point(79, 71);
      AddAuthorTextBox.Name = "AddAuthorTextBox";
      AddAuthorTextBox.Size = new Size(160, 23);
      AddAuthorTextBox.TabIndex = 2;
      // 
      // TitleLabel
      // 
      TitleLabel.AutoSize = true;
      TitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      TitleLabel.Location = new Point(38, 34);
      TitleLabel.Name = "TitleLabel";
      TitleLabel.Size = new Size(35, 15);
      TitleLabel.TabIndex = 14;
      TitleLabel.Text = "Title:";
      // 
      // AddTitleTextBox
      // 
      AddTitleTextBox.Location = new Point(79, 31);
      AddTitleTextBox.Name = "AddTitleTextBox";
      AddTitleTextBox.Size = new Size(160, 23);
      AddTitleTextBox.TabIndex = 1;
      // 
      // BooksPic
      // 
      BooksPic.BackColor = SystemColors.Window;
      BooksPic.Location = new Point(337, 29);
      BooksPic.Name = "BooksPic";
      BooksPic.Size = new Size(135, 118);
      BooksPic.SizeMode = PictureBoxSizeMode.Zoom;
      BooksPic.TabIndex = 12;
      BooksPic.TabStop = false;
      // 
      // TotalAvailableBooksLabel
      // 
      TotalAvailableBooksLabel.AutoSize = true;
      TotalAvailableBooksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
      TotalAvailableBooksLabel.Location = new Point(180, 120);
      TotalAvailableBooksLabel.Name = "TotalAvailableBooksLabel";
      TotalAvailableBooksLabel.Size = new Size(0, 25);
      TotalAvailableBooksLabel.TabIndex = 2;
      // 
      // roundedPanel2
      // 
      roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      roundedPanel2.BackColor = SystemColors.Control;
      roundedPanel2.BorderRadius = 30;
      roundedPanel2.Controls.Add(ListOfBooksDataGridView);
      roundedPanel2.Controls.Add(ListOfBooksLabel);
      roundedPanel2.Location = new Point(38, 34);
      roundedPanel2.Name = "roundedPanel2";
      roundedPanel2.Size = new Size(722, 342);
      roundedPanel2.TabIndex = 24;
      // 
      // ListOfBooksDataGridView
      // 
      ListOfBooksDataGridView.AllowUserToAddRows = false;
      ListOfBooksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      ListOfBooksDataGridView.BackgroundColor = SystemColors.Control;
      ListOfBooksDataGridView.BorderStyle = BorderStyle.None;
      ListOfBooksDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = Color.Green;
      dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      dataGridViewCellStyle1.ForeColor = Color.White;
      dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      ListOfBooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      ListOfBooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ListOfBooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
      dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
      dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
      dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      ListOfBooksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
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
      // ListOfBooksLabel
      // 
      ListOfBooksLabel.AutoSize = true;
      ListOfBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      ListOfBooksLabel.Location = new Point(24, 5);
      ListOfBooksLabel.Name = "ListOfBooksLabel";
      ListOfBooksLabel.Size = new Size(110, 21);
      ListOfBooksLabel.TabIndex = 0;
      ListOfBooksLabel.Text = "List of books:";
      // 
      // ManageBooksPanel
      // 
      AutoScaleDimensions = new SizeF(96F, 96F);
      AutoScaleMode = AutoScaleMode.Dpi;
      BackColor = SystemColors.ButtonHighlight;
      Controls.Add(roundedPanel2);
      Controls.Add(roundedPanel1);
      Name = "ManageBooksPanel";
      Size = new Size(800, 687);
      roundedPanel1.ResumeLayout(false);
      roundedPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)BooksPic).EndInit();
      roundedPanel2.ResumeLayout(false);
      roundedPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ListOfBooksDataGridView).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Custom_Controls.RoundedPanel roundedPanel1;
    private Label TotalAvailableBooksLabel;
    private Button AddBtn;
    private Label TitleLabel;
    private TextBox AddTitleTextBox;
    private PictureBox BooksPic;
    private Label PublishedLabel;
    private Label AuthorLabel;
    private TextBox AddAuthorTextBox;
    private Label StatusLabel;
    private DateTimePicker AddPublishedDateTImePicker;
    private ComboBox AddStatusBooksComboBox;
    private Button DeleteBtn;
    private Button UpdateBtn;
    private Custom_Controls.RoundedPanel roundedPanel2;
    private Label ListOfBooksLabel;
    private Button ImportImageBtn;
    private DataGridView ListOfBooksDataGridView;
    private Button ClearBtn;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
  }
}
