using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace HaloWidget.Widget
{
    public class HaloListBoxBase : ListBox
    {
        private Color backGroundColor;
        private Color selectedBackGroundColor;
        private Color fontColor;
        private Color selectedFontColor;

        [Category("Halo Settings")]
        public Color BackGroundColor
        {
            get => backGroundColor;
            set
            {
                backGroundColor = value;
                BackColor = backGroundColor;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color SelectedBackGroundColor
        {
            get => selectedBackGroundColor;
            set
            {
                selectedBackGroundColor = value;
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

        public HaloListBoxBase() 
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DrawMode = DrawMode.OwnerDrawVariable;

            BorderStyle = BorderStyle.None;
            ItemHeight = 36;

            DrawItem += new DrawItemEventHandler(ComboBox_DrawItem);
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter ;
            
            if (e.Index < 0 || Items.Count <= 0) return;

            using (Font font = new Font("calibri", 10, FontStyle.Bold))
            {
                Brush brush;
                Color color;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = new SolidBrush(selectedBackGroundColor);
                    color = selectedFontColor;
                }
                else
                {
                    brush = new SolidBrush(backGroundColor);
                    color = fontColor;
                }

                e.Graphics.FillRectangle(brush, e.Bounds);
                TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), font, e.Bounds, color, flags);

                brush.Dispose();
            }
        }
    }
}
