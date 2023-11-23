using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloWidget.Widget
{
    public class HaloTabControlBase : TabControl
    {
        private int verticalMargin = 3;
        private int tabWidth = 80;
        private int tabHeight = 0;

        private Color itemColor = Color.WhiteSmoke;
        private Color selectedItemColor = Color.Gray;
        private Color fontColor = Color.DarkGray;
        private Color selectedFontColor = Color.Black;

        [Category("Halo Settings")]
        public int TabWidth
        {
            get => tabWidth;
            set
            {
                tabWidth = value;
                ItemSize = new Size(tabWidth, tabHeight);
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public int TabHeight
        {
            get => tabHeight;
            set
            {
                if (value < Font.Height + verticalMargin)
                    value = Font.Height + verticalMargin;

                tabHeight = value;
                ItemSize = new Size(tabWidth, tabHeight);
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public Color ItemColor
        {
            get => itemColor;
            set
            {
                itemColor = value;
                Invalidate();
            }
        }
        [Category("Halo Settings")]
        public Color SelectedItemColor
        {
            get => selectedItemColor;
            set
            {
                selectedItemColor = value;
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

        public HaloTabControlBase()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            TabHeight = Font.Height + verticalMargin * 2;

            ItemSize = new Size(100, Font.Height + 6);
            DrawMode = TabDrawMode.OwnerDrawFixed;
            SizeMode = TabSizeMode.Fixed;

            DrawItem += new DrawItemEventHandler(TabControl_DrawItem);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Graphics graphic = e.Graphics;

            Brush brush = new SolidBrush(itemColor);

            Rectangle tabArea = GetTabRect(e.Index);

            Color fColor = fontColor;

            using (Font font = new Font("calibri", 10, FontStyle.Bold))
            {
                if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = new SolidBrush(selectedItemColor);
                    fColor = selectedFontColor;
                }

                graphic.FillRectangle(brush, tabArea);
                TextRenderer.DrawText(graphic, TabPages[e.Index].Text, font, tabArea, fColor, flags);
            }
        }


    }
}
