using HaloWidget;
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

namespace HaloWidget
{
    public partial class MainForm : HaloFormBase
    {
        private bool isKeyDown = false;
        private Point winPos;

        public bool IsKeyDown
        {
            get => isKeyDown;
        }
        public Point WinPos
        {
            get => winPos;
        }

        public MainForm()
        {
            InitializeComponent();

            winPos = Location;
            haloTitleBase1.MouseDownEvent += MainForm_MouseDown;
            haloTitleBase1.MouseUpEvent += MainForm_MouseUp;
            haloTitleBase1.MouseMoveEvent += MainForm_MouseMove;

            haloListBoxBase1.SelectedIndexChanged += new EventHandler(ListBox_Changed);
        }

        private void ListBox_Changed(object sender, EventArgs e)
        {
            label1.Text = haloListBoxBase1.SelectedItem.ToString();
        }

        private void haloButton1_Click(object sender, EventArgs e)
        {
            if (Mode == "light")
                Mode = "dark";
                
            else
                Mode = "light";

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("hi");

            if (e.Button != MouseButtons.Left)
                return;

            isKeyDown = true;
            winPos = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isKeyDown)
                return;

            int deltaX, deltaY;
            deltaX = e.X - winPos.X;
            deltaY = e.Y - winPos.Y;

            Location = new Point(Location.X + (deltaX), Location.Y + (deltaY));
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isKeyDown = false;
            winPos = e.Location;
        }

        #region for sizable
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;
            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
        #endregion
    }
}
