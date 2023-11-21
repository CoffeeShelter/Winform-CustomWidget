using HaloWidgets.Widget;
using HaloWidget.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloWidget
{
    public class HaloFormBase : Form
    {
        private string mode = "light";

        [Category("Halo Settings")]
        public string Mode
        {
            get => mode;
            set
            {
                mode = value;
                if (mode == "light")
                {
                    ModeChangedEventArgs args = new ModeChangedEventArgs();
                    args.Mode = mode;
                    ModeChanged?.Invoke(this, args);
                }
                else if (mode == "dark")
                {
                    ModeChangedEventArgs args = new ModeChangedEventArgs();
                    args.Mode = mode;
                    ModeChanged?.Invoke(this, args);
                }
            }
        }

        public event EventHandler ModeChanged;

        [Category("Halo Settings")]
        public Color BackgroundColor
        {
            get => BackColor;
            set
            {
                BackColor = value;
                Invalidate();
            }
        }

        public HaloFormBase()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ModeChanged += new EventHandler(Mode_Changed);
        }

        public void Mode_Changed(object sender, EventArgs e)
        {
            ModeChangedEventArgs args = e as ModeChangedEventArgs;
            if (args.Mode == "light")
                BackgroundColor = HaloColor.LightBackGround;
            else if (args.Mode == "dark")
                BackgroundColor = HaloColor.DarkBackGround;
        }
    }
}
