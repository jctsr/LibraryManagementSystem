using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem.Classes
{
    public class Draggable
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        // Call this method in the MouseDown event of the control
        public void MakeDraggable(Control control)
        {
            control.MouseDown += (s, e) =>
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            };

            control.MouseMove += (s, e) =>
            {
                if (isDragging && control.Parent != null)
                {
                    control.Parent.Location = new Point(control.Parent.Location.X + e.X - startPoint.X, control.Parent.Location.Y + e.Y - startPoint.Y);
                }
            };

            control.MouseUp += (s, e) =>
            {
                isDragging = false;
            };
        }
    }
}
