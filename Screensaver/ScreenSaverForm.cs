using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;

namespace Screensaver
{
    public partial class ScreenSaverForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        String imagePath;
        bool showText;
        bool showDateTime;
        string customText;
        string customTextColor;
        Color foreground;

        Rectangle area;

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
            area = Screen.FromControl(this).WorkingArea;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            // Load Registry-Keys
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MJScreenSaver");
            if (key == null)
            {
                // Defaultsettings
                imagePath = "";
                showText = false;
                showDateTime = false;
                customText = "";
                customTextColor = Color.Black.ToString();
            }
            else
            {
                try
                {
                    // Registry-Settings
                    imagePath = (string)key.GetValue("imagepath");
                    showText = Convert.ToBoolean((string)key.GetValue("showText"));
                    showDateTime = Convert.ToBoolean((string)key.GetValue("showDateTime"));
                    customText = (string)key.GetValue("customText");
                    customTextColor = (string)key.GetValue("customTextColor");
                    foreground = Color.FromArgb(Convert.ToInt32(customTextColor));
                }
                catch (Exception ex)
                {
                    // Called when one of the Registry-Values is not available
                    // Just Re-Saving should fix it
                }
            }

            // Load pictures from custom path
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }

            // Load Label
            if (customText != "" && showText)
            {            
                lblCustom.AutoSize = true;
                lblCustom.Font = new Font(lblCustom.Font.FontFamily, 48);
                lblCustom.Location = new Point(100, 100);
                lblCustom.Text = customText;
                lblCustom.ForeColor = foreground;
            }
            else
            {
                lblCustom.Text = "";
            }

            if(showDateTime)
            {
                lblDate.AutoSize = true;
                lblDate.Font = new Font(lblDate.Font.FontFamily, 48);
                lblDate.Location = new Point(100, area.Height - lblDate.Height / 2 - 100);
                lblDate.Text = DateTime.Now.ToLongDateString();
                lblDate.ForeColor = foreground;

                lblTime.AutoSize = true;
                lblTime.Font = new Font(lblTime.Font.FontFamily, 72);
                lblTime.Location = new Point(100, area.Height - lblDate.Height / 2 - lblTime.Height - 100);
                lblTime.Text = DateTime.Now.ToLongTimeString();
                lblTime.ForeColor = foreground;

                
            }
        }

        // Terminate app when user interacts
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Currently not wanted
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void tClockTick_Tick(object sender, EventArgs e)
        {
            if(showDateTime)
            {
                lblTime.Text = DateTime.Now.ToLongTimeString();
            }
        }
    }
}
