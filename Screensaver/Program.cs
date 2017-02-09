/*
 * Screensaver receives command-line-arguments to set mode:
    /p - Display in screensaver selection dialogue box
    /c - Display in configuration dialogue box
    /s - Display full-screen 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screensaver
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                if (firstArgument == "/c")           // Config
                {
                    Application.Run(new SettingsForm());
                }
                else if (firstArgument == "/p")      // Preview
                {
                    // TODO
                }
                else if (firstArgument == "/s")      // Full-screen
                {
                    ShowScreenSaver();
                    Application.Run();
                }
                else    // Undefined
                {
                    MessageBox.Show("Invalid Argument: \"" + firstArgument +"\".", "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else    // Run Config when no arguments are available
            {
                Application.Run(new SettingsForm());
            }
        }

        static void ShowScreenSaver()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                ScreenSaverForm screensaver = new ScreenSaverForm(screen.Bounds);
                screensaver.Show();
            }
        }
    }
}
