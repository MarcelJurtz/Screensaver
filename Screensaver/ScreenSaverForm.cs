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

        String folderPath;
        bool useCustom;
        bool useDefault;
        int changeInterval;
        List<String> imagePaths;
        Random random;
        int currentSeconds;

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;
            random = new Random();
            imagePaths = new List<string>();

            // Load Registry-Keys
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MJScreenSaver");
            if (key == null)
            {
                // Defaultsettings
                folderPath = "";
                useCustom = false;
                useDefault = true;
                changeInterval = 30;
            }
            else
            {
                try
                {
                    // Registry-Settings
                    folderPath = (string)key.GetValue("folderpath");
                    useCustom = Convert.ToBoolean((string)key.GetValue("useCustom"));
                    useDefault = Convert.ToBoolean((string)key.GetValue("useDefault"));
                    changeInterval = (int)key.GetValue("intervalSeconds");
                }
                catch (Exception ex)
                {
                    // Called when one of the Registry-Values is not available
                    // Just Re-Saving should fix it
                }
            }

            // Load pictures from custom path
            if (useCustom && Directory.Exists(folderPath))
            {
                foreach (String imagePath in Directory.GetFiles(folderPath, "*.jpg"))
                {
                    imagePaths.Add(imagePath);
                }
            }

            // Load pictures from default path
            if (useDefault)
            {
                string path = System.Environment.CurrentDirectory;
                string path2 = path.Substring(0, path.LastIndexOf("bin")) + "DefaultImages";

                foreach (String imagePath in Directory.GetFiles(path2))
                {
                    imagePaths.Add(imagePath);
                }
            }

            // Timer starts at 1, not 0
            currentSeconds = 1;
            timer.Interval = 1000 * changeInterval;
            timer.Start();

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

        private void timer_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(imagePaths[random.Next(0, imagePaths.Count)]);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
