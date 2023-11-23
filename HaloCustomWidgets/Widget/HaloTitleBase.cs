using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HaloCustomWidgets.Widget
{
    public partial class HaloTitleBase : UserControl
    {
        private string titleText = "Here is title area";
        private Font titleFont = new Font("calibri", 10, FontStyle.Regular);
        private Color fontColor = Color.Black;

        private MouseEventHandler mouseDownEvent;
        private MouseEventHandler mouseUpEvent;
        private MouseEventHandler mouseMoveEvent;

        public MouseEventHandler MouseDownEvent
        {
            get => mouseDownEvent;
            set
            {
                mouseDownEvent = value;
                _titleLabel.MouseDown += MouseDownEvent;
                _titleLayout.MouseDown += MouseDownEvent;
            }
        }

        public MouseEventHandler MouseUpEvent
        {
            get => mouseUpEvent;
            set
            {
                mouseUpEvent = value;
                _titleLabel.MouseUp += mouseUpEvent;
                _titleLayout.MouseUp += mouseUpEvent;
            }
        }

        public MouseEventHandler MouseMoveEvent
        {
            get => mouseMoveEvent;
            set
            {
                mouseMoveEvent = value;
                _titleLabel.MouseMove += mouseMoveEvent;
                _titleLayout.MouseMove += mouseMoveEvent;
            }
        }

        [Category("Halo Settings")]
        public Font TitleFont
        {
            get => titleFont;
            set
            {
                titleFont = value;
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
                _titleLabel.ForeColor = fontColor;
                Invalidate();
            }
        }

        [Category("Halo Settings")]
        public string TitleText
        {
            get => titleText;
            set
            {
                titleText = value;
                _titleLabel.Text = titleText;
                Invalidate();
            }
        }


        public HaloTitleBase()
        {
            InitializeComponent();
        }

        private void _ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
