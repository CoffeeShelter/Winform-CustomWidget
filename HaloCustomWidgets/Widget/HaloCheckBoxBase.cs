using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace HaloWidget.Widget
{
    public class HaloCheckBoxBase : CheckBox
    {
        private Color iconColor = Color.LightGray;
        private Color checkedIconColor = Color.Black;
        private Color fontColor = Color.Black;
        private Color selectedFontColor = Color.Black;
        private Color backGroundColor = Color.AliceBlue;

        [Category("Halo Settings")]
        public Color IconColor
        {
            get => iconColor;
            set
            {
                iconColor = value;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color CheckedIconColor
        {
            get => checkedIconColor;
            set
            {
                checkedIconColor = value;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color FontColor
        {
            get => fontColor;
            set
            {
                fontColor = value;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color SelectedFontColor
        {
            get => selectedFontColor;
            set
            {
                selectedFontColor = value;
                Invalidate();
            }
        }
        [Category("Halo Settings")]
        public Color BackGroundColor
        {
            get => backGroundColor;
            set
            {
                backGroundColor = value;
                Invalidate();
            }
        }

        public HaloCheckBoxBase()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.PathEllipsis;

            int iconSize = 10;
            int iconMargin = (Height - iconSize) / 2;
            int leftMargin = 3;

            Color fColor = fontColor;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Checked ? checkedIconColor : iconColor, 2))
            using (SolidBrush mBrush = new SolidBrush(backGroundColor))
            using (SolidBrush checkedBrush = new SolidBrush(checkedIconColor))
            using (Font font = new Font("calibri", 10, FontStyle.Bold))
            {
                int fontMarging = (Height - font.Height) / 2;
                Rectangle iconRectangle = new Rectangle(leftMargin, iconMargin, iconSize, iconSize);
                Rectangle textRectangle = new Rectangle((iconRectangle.X + iconRectangle.Width) + leftMargin, fontMarging, (Width - (iconRectangle.X + iconRectangle.Width)) - fontMarging, font.Height);
                pevent.Graphics.FillRectangle(mBrush, new Rectangle(0, 0, Width, Height));

                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                path.StartFigure();
                path.AddRectangle(iconRectangle);
                path.CloseFigure();

                pevent.Graphics.DrawPath(pen, path);
                if (Checked)
                {
                    pevent.Graphics.FillPath(checkedBrush, path);
                    fColor = selectedFontColor;
                }

                TextRenderer.DrawText(pevent.Graphics, Text, font, textRectangle, fColor, flags);
            }
        }
    }
}
