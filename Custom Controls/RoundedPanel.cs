using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Custom_Controls
{
  public class RoundedPanel : Panel
  {
    public int borderRadius = 30;
    public int BorderRadius
    {
      get { return borderRadius; }
      set
      {
        borderRadius = value;
        this.Invalidate();
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      using (GraphicsPath path = new GraphicsPath())
      {
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);

        using (Pen pen = new Pen(this.BackColor, 2))
        {
          e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
          e.Graphics.DrawPath(pen, path);
        }
      }
    }
  }
}
