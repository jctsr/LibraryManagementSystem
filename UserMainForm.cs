using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
    public partial class UserMainForm : Form
  {
    private Draggable Draggable = new();

    private MakeForm_ButtonRounded MakeForm_ButtonRounded = new();

    public UserMainForm()
    {
      InitializeComponent();

      Draggable.MakeDraggable(TopPanel);

      this.Region = System.Drawing.Region.FromHrgn(MakeForm_ButtonRounded.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes) Application.Exit();
    }
  }
}
