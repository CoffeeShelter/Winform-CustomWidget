using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloWidgets.Widget
{
    public class HaloTrackBarBase : TrackBar
    {
        private int barSize = 16;

        private Color lineColor = Color.DarkGray;
        private Color barColor = Color.Black;

        public int BarSize
        {
            get => barSize;
            set
            {
                barSize = value;
                Invalidate();
            }
        }

        public Color LineColor
        {
            get => lineColor;
            set
            {
                lineColor = value;
                Invalidate();
            }
        }
        public Color BarColor
        {
            get => barColor;
            set
            {
                barColor = value;
                Invalidate();
            }
        }

        public HaloTrackBarBase()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            ValueChanged += HaloTrackBarBase_ValueChanged;
        }

        private void HaloTrackBarBase_ValueChanged(object sender, EventArgs e)
        {
            Painting();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            
        }

        private void Painting()
        {
            Invalidate();
            Update();
            Graphics graphics = CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int x = Width * Value / Maximum;

            using (Pen filllinePen = new Pen(Color.Red))
            using (Pen linePen = new Pen(lineColor))
            using (Brush barBrush = new SolidBrush(barColor))
            {
                graphics.DrawLine(filllinePen, ClientRectangle.X, ClientRectangle.Height / 2, x, ClientRectangle.Height / 2);
                graphics.FillEllipse(barBrush, x, ClientRectangle.Height / 2 - barSize / 2, barSize, barSize);
                graphics.DrawLine(linePen, x + barSize, ClientRectangle.Height / 2, ClientRectangle.Width, ClientRectangle.Height / 2);

            }
            Update();
        }

    }
}
