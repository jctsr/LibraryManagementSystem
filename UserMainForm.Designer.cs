namespace LibraryManagementSystem
{
  partial class UserMainForm
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
      AdminPanel = new Custom_Controls.RoundedPanel();
      TopPanel.SuspendLayout();
      SuspendLayout();
      // 
      // TopPanel
      // 
      TopPanel.Controls.Add(closeBtn);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(0, 0);
      TopPanel.Name = "TopPanel";
      TopPanel.Size = new Size(1280, 40);
      TopPanel.TabIndex = 2;
      // 
      // closeBtn
      // 
      closeBtn.BackColor = SystemColors.Control;
      closeBtn.Cursor = Cursors.Hand;
      closeBtn.FlatAppearance.BorderSize = 0;
      closeBtn.FlatStyle = FlatStyle.Flat;
      closeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      closeBtn.ForeColor = SystemColors.ControlText;
      closeBtn.Location = new Point(1212, 1);
      closeBtn.Name = "closeBtn";
      closeBtn.Size = new Size(68, 38);
      closeBtn.TabIndex = 7;
      closeBtn.TabStop = false;
      closeBtn.Text = "X";
      closeBtn.UseVisualStyleBackColor = false;
      closeBtn.Click += closeBtn_Click;
      // 
      // AdminPanel
      // 
      AdminPanel.BackColor = SystemColors.ButtonHighlight;
      AdminPanel.BorderRadius = 30;
      AdminPanel.Location = new Point(42, 61);
      AdminPanel.Name = "AdminPanel";
      AdminPanel.Size = new Size(341, 687);
      AdminPanel.TabIndex = 3;
      // 
      // UserMainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1280, 800);
      Controls.Add(AdminPanel);
      Controls.Add(TopPanel);
      FormBorderStyle = FormBorderStyle.None;
      Name = "UserMainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "UserMainForm";
      TopPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel TopPanel;
    private Button closeBtn;
    private Custom_Controls.RoundedPanel AdminPanel;
  }
}