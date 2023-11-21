using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace HaloWidget.Widget
{
    public class HaloComboBoxBase : ComboBox
    {
        private Color inSideBackColor = Color.White;
        private Color outSideBackColor = Color.White;
        private Color inSideTextColor = Color.Black;
        private Color outSideTextColor = Color.Black;
        private Color arrowIconColor = Color.Black;

        private float fontSize = 12f;
        private int arrowIconSize = 16;

        [Category("Halo Settings")]
        public Color InSideBackGroundColor
        {
            get => inSideBackColor;
            set
            {
                inSideBackColor = value;
                BackColor = inSideBackColor;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color OutSideBackGroundColor
        {
            get => outSideBackColor;
            set
            {
                outSideBackColor = value;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color TextColor
        {
            get => ForeColor;
            set
            {
                outSideTextColor = value;
                ForeColor = outSideTextColor;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color ItemTextColor
        {
            get => inSideTextColor;
            set
            {
                inSideTextColor = value;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color ArrowIconColor
        {
            get => arrowIconColor;
            set
            {
                arrowIconColor = value;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public int ArrowIconSize
        {
            get => arrowIconSize;
            set
            {
                arrowIconSize = value;
                Invalidate();
            }
        }

        public HaloComboBoxBase()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawVariable;

            DrawItem += new DrawItemEventHandler(ComboBox_DrawItem);
            MeasureItem += new MeasureItemEventHandler(ComboBox_MeasureItem);

            
        }

        private void ComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            switch (e.Index)
            {
                default:
                    e.ItemHeight = Height;
                    e.ItemWidth = Width;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.PathEllipsis;

            int iconMargin = (Height - arrowIconSize) / 2;
            int rightMargin = 6;

            if (iconMargin <= 0)
                iconMargin = 0;

            if (arrowIconSize > Height - (iconMargin * 2))
                arrowIconSize = Height - (iconMargin * 2);
            
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Color.Black))
            using (SolidBrush mBrush = new SolidBrush(outSideBackColor))
            {
                pevent.Graphics.FillRectangle(mBrush, new Rectangle(0, 0, Width, Height));

                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                path.StartFigure();
                path.AddLine(Width - arrowIconSize - rightMargin, iconMargin, Width - rightMargin, iconMargin);
                path.AddLine(Width - rightMargin, iconMargin, Width - (arrowIconSize / 2) - rightMargin, iconMargin + arrowIconSize);
                path.AddLine(Width - arrowIconSize - rightMargin, iconMargin, Width - (arrowIconSize / 2) - rightMargin, iconMargin + arrowIconSize);
                path.CloseFigure();

                pevent.Graphics.FillPath(new SolidBrush(arrowIconColor), path);
                pevent.Graphics.DrawPath(pen, path);
            }

            if (Items.Count <= 0)
                return;

            if (SelectedIndex >= 0)
            {
                using (Font font = new Font("calibri", fontSize, FontStyle.Bold))
                {
                    TextRenderer.DrawText(pevent.Graphics, SelectedItem.ToString(), font, ClientRectangle, inSideTextColor, flags);
                }
            }
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;

            e.DrawBackground();

            if (e.Index < 0) return;

            using (Font font = new Font("calibri", 10, FontStyle.Bold))
            {
                TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), font, e.Bounds, inSideTextColor, flags);
                //e.Graphics.DrawString(Items[e.Index].ToString(), font, new SolidBrush(inSideTextColor), e.Bounds.X, e.Bounds.Y);
            }

            e.DrawFocusRectangle();
        }
    }
}
