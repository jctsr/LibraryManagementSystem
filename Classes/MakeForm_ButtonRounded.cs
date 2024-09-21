using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class MakeForm_ButtonRounded
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern nint CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public void MakeButtonRounded(Button button)
        {
            int borderRadius = 19;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(button.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, button.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            button.Region = new Region(path);
        }
    }
}
