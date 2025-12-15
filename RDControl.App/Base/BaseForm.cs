using System.Runtime.InteropServices;

namespace RDControl.App.Base
{
    public partial class BaseForm : Form
    {
        #region Constructor Method
        public BaseForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #endregion

        #region Events
        private void btnWinClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", @"Duda RD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected void MoverFormulario(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        #endregion

        #region Methods
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int RESIZE_HANDLE_SIZE = 30;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if ((int)m.Result == 0x01)
                {
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = this.PointToClient(screenPoint);

                    if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                    {
                        if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)20; // TopLeft
                        else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                            m.Result = (IntPtr)19; // Top
                        else
                            m.Result = (IntPtr)21; // TopRight
                    }
                    else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                    {
                        if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)20; // Left
                        else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                            m.Result = (IntPtr)2;  // Caption 
                        else
                            m.Result = (IntPtr)21; // Right
                    }
                    else
                    {
                        if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)20; // BottomLeft
                        else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                            m.Result = (IntPtr)19; // Bottom
                        else
                            m.Result = (IntPtr)21; // BottomRight
                    }
                }
                return;
            }
            base.WndProc(ref m);
        }

        #endregion
    }
}
