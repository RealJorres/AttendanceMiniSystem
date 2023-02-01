using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgrammingFinalProject
{
    class CircularButtons: Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddEllipse(2, 2, ClientSize.Width-5, ClientSize.Height-5);
            this.Region = new System.Drawing.Region(gPath);
            base.OnPaint(pevent);
        }
    }
}
