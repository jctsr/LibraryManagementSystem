using System.Drawing.Drawing2D;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
    public partial class LoadingScreen : Form
  {
    private Draggable Draggable = new();

    public LoadingScreen()
    {
      InitializeComponent();

      Draggable.MakeDraggable(LoadingPictureBox);
    }

    private void AdjustPictureBoxForDpi()
    {
      // Get the current DPI scale factor
      float dpiScale = this.DeviceDpi / 96f; // Default DPI is 96

      // Calculate the new size based on DPI scaling (adjust for the 125% scaling, for example)
      int adjustedWidth = (int)(800 * dpiScale);
      int adjustedHeight = (int)(450 * dpiScale);

      // Set the PictureBox size
      LoadingPictureBox.Size = new Size(adjustedWidth, adjustedHeight);

      // Center the PictureBox within the form
      LoadingPictureBox.Location = new Point(
          (this.ClientSize.Width - LoadingPictureBox.Width) / 2,
          (this.ClientSize.Height - LoadingPictureBox.Height) / 2
      );
    }



    private void timer1_Tick(object sender, EventArgs e)
    {
      loadingProgress.Increment(1);

      if (loadingProgress.Value == 100)
      {
        timer1.Stop();

        LoginForm loginForm = new();

        loginForm.Show();

        this.Hide();
      }
    }

    private void LoadingScreen_Resize(object sender, EventArgs e)
    {
      AdjustPictureBoxForDpi();
    }
  }
}
