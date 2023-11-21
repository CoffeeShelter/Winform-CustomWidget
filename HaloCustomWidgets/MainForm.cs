using HaloWidget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloWidget
{
    public partial class MainForm : HaloFormBase
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void haloButton1_Click(object sender, EventArgs e)
        {
            if (Mode == "light")
                Mode = "dark";
            else
                Mode = "light";
        }
    }
}
