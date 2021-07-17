using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoPianoTeacher
{
    public class CanvasControl : Control
    {
        public CanvasControl() { }
        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(ForeColor),new Rectangle(new Point(2,2) ,new Size(1000,400)));
        }
    }
}
