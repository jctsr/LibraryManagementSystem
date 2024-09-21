namespace LibraryManagementSystem
{
  partial class LoadingScreen
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      label1 = new Label();
      LoadingPictureBox = new PictureBox();
      timer1 = new System.Windows.Forms.Timer(components);
      label2 = new Label();
      loadingProgress = new ProgressBar();
      ((System.ComponentModel.ISupportInitialize)LoadingPictureBox).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = Color.Transparent;
      label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      label1.Location = new Point(232, 472);
      label1.Name = "label1";
      label1.Size = new Size(340, 32);
      label1.TabIndex = 0;
      label1.Text = "Library Management System";
      // 
      // LoadingPictureBox
      // 
      LoadingPictureBox.Dock = DockStyle.Top;
      LoadingPictureBox.Image = Properties.Resources.enchanted_library;
      LoadingPictureBox.Location = new Point(0, 0);
      LoadingPictureBox.Name = "LoadingPictureBox";
      LoadingPictureBox.Size = new Size(800, 450);
      LoadingPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
      LoadingPictureBox.TabIndex = 1;
      LoadingPictureBox.TabStop = false;
      // 
      // timer1
      // 
      timer1.Enabled = true;
      timer1.Interval = 20;
      timer1.Tick += timer1_Tick;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      label2.ForeColor = SystemColors.ControlText;
      label2.Location = new Point(12, 518);
      label2.Name = "label2";
      label2.Size = new Size(59, 15);
      label2.TabIndex = 3;
      label2.Text = "Loading...";
      // 
      // loadingProgress
      // 
      loadingProgress.BackColor = SystemColors.ControlDarkDark;
      loadingProgress.Location = new Point(12, 536);
      loadingProgress.Name = "loadingProgress";
      loadingProgress.Size = new Size(775, 22);
      loadingProgress.TabIndex = 4;
      // 
      // LoadingScreen
      // 
      AutoScaleMode = AutoScaleMode.None;
      ClientSize = new Size(800, 600);
      Controls.Add(loadingProgress);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(LoadingPictureBox);
      FormBorderStyle = FormBorderStyle.None;
      MinimumSize = new Size(800, 600);
      Name = "LoadingScreen";
      Opacity = 0.97D;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form1";
      Resize += LoadingScreen_Resize;
      ((System.ComponentModel.ISupportInitialize)LoadingPictureBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private PictureBox LoadingPictureBox;
    private System.Windows.Forms.Timer timer1;
    private Label label2;
    private ProgressBar loadingProgress;
  }
}
