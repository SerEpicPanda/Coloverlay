using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Coloverlay
{
    public partial class OverlayWindow : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        bool opacityToggle = true;
        bool preventClose = true;
        int borderSize = 25;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public OverlayWindow()
        {
            InitializeComponent();
            RegisterHotKey(Handle, 333, 0x0001, (int)Keys.V);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTime)
            {
                ShowHelp();
            }
            Location = Properties.Settings.Default.WindowPos;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            KeyDown += OverlayWindow_KeyPress;
            FormClosing += Form1_FormClosing;
            MouseMove += ChangeSize;
            ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = preventClose;
            opacityToggle = !opacityToggle;
            Hide();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                opacityToggle = !opacityToggle;
            }
        }

        private void ChangeSize(object sender, MouseEventArgs e)
        {
            if (e.Location.X > Width - borderSize)
            {
                if (e.Location.Y > Height - borderSize)
                {
                    Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    Cursor = Cursors.SizeWE;
                }
            }
            else if (e.Location.Y > Height - borderSize)
            {
                Cursor = Cursors.SizeNS;
            }
            else
            {
                Cursor = Cursors.SizeAll;
            }
            if (e.Button == MouseButtons.Left)
            {
                if (e.Location.X > Width - borderSize)
                {
                    if(e.Location.Y > Height - borderSize)
                    {
                        Size = new System.Drawing.Size(e.X + 5, e.Y + 5);
                    } else
                    {
                        Size = new System.Drawing.Size(e.X + 5, Height);
                    }
                }
                else if (e.Location.Y > Height - borderSize)
                {
                    Size = new System.Drawing.Size(Width, e.Y + 5);
                }
                else
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void OverlayWindow_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
                PickColour();
            if (e.KeyCode == Keys.Z)
                DecOpacity();
            if (e.KeyCode == Keys.X)
                IncOpacity();
            if (e.KeyCode == Keys.K)
                CloseOverlay();
            if (e.KeyCode == Keys.Escape)
            {
                if (opacityToggle)
                {
                    Hide();
                }
                opacityToggle = !opacityToggle;
            }
            if (e.KeyCode == Keys.H)
                ShowHelp();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == 333)
                {
                    if (opacityToggle)
                    {
                        Hide();
                    }
                    else
                    {
                        Show();
                    }
                    opacityToggle = !opacityToggle;
                }
            }

            base.WndProc(ref m);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOverlay();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PickColour();
        }

        private void ShowHelp()
        {
            var helpForm = new HelpWindow();
            helpForm.Show();
        }

        private void IncOpacity()
        {
            if (Opacity < 1)
            {
                Opacity += 0.05;
            }
        }

        private void DecOpacity()
        {
            if (Opacity > 0.1)
            {
                Opacity -= 0.05;
            }
        }

        private void CloseOverlay()
        {
            Properties.Settings.Default.WindowPos = Location;
            Properties.Settings.Default.OverlayOpacity = Opacity;
            Properties.Settings.Default.FirstTime = false;
            Properties.Settings.Default.OverlayColor = BackColor;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            notifyIcon.Icon = null;
            notifyIcon.Dispose();
            Properties.Settings.Default.Save();
            preventClose = false;
            Application.Exit();
        }

        private void PickColour()
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorPicker.Color;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void incOpacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncOpacity();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecOpacity();
        }

        private void colorCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PickColour();
        }

        private void incOpacityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IncOpacity();
        }

        private void decOpacityXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecOpacity();
        }

        private void closeKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOverlay();
        }
    }
}
