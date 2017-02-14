using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Screensaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        String folderpath;
        bool useCustom;
        bool useDefault;
        int intervalSeconds;
        string customText;
        string customTextColor;

        // Registry-Keys
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MJScreenSaver");
            if (key == null)
            {
                // Defaultsettings
                folderpath = "";
                useCustom = false;
                useDefault = true;
                intervalSeconds = 30;
                customText = "";
                customTextColor = Color.Black.ToString();
            }
            else
            {
                try
                {
                    // Registry-Settings
                    folderpath = (string)key.GetValue("folderpath");
                    useCustom = Convert.ToBoolean((string)key.GetValue("useCustom"));
                    useDefault = Convert.ToBoolean((string)key.GetValue("useDefault"));
                    intervalSeconds = (int)key.GetValue("intervalSeconds");
                    customText = (string)key.GetValue("customText");
                    customTextColor = (string)key.GetValue("customTextColor");
                }
                catch(Exception ex)
                {
                    // Called when one of the Registry-Values is not available
                    // Just Re-Saving should fix it
                }
            }

            if (!Directory.Exists(folderpath))
            {
                folderpath = "";
            }

            chkUseCustom.Checked = useCustom;
            chkUseDefault.Checked = useDefault;
            txtFolderPath.Text = folderpath;
            txtChangeInterval.Text = intervalSeconds.ToString();
            txtCustomText.Text = customText;

            txtFolderPath.Enabled = chkUseCustom.Checked;
            cmdFolderSelect.Enabled = chkUseCustom.Checked;

        }

        // Create and set Registry-Key
        private void saveKey()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MJScreenSaver");
            key.SetValue("folderpath", txtFolderPath.Text);
            key.SetValue("useCustom", chkUseCustom.Checked);
            key.SetValue("useDefault", chkUseDefault.Checked);
            key.SetValue("intervalSeconds", Convert.ToInt32(txtChangeInterval.Text));
            key.SetValue("customText", txtCustomText.Text);
            key.SetValue("customTextColor", customTextColor);        
        }

        // Button Cancel
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Button Save
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (chkUseCustom.Checked && txtFolderPath.Text == "") MessageBox.Show("Kein Pfad für Bilder festgelegt.\nBitte füge einen Pfad ein.", "Fehler beim Speicher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                saveKey();
                Close();
            }            
        }


        // Controls
        private void chkUseDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkUseCustom.Checked)
            {
                chkUseDefault.Checked = true;
            }
        }

        private void cmdFolderSelect_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = fbd.SelectedPath;
            }
        }
      
        private void txtChangeInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only accept numbers as Input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmdSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                customTextColor = colorDialog.Color.ToArgb().ToString();
        }

        private void chkUseCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtFolderPath.Enabled = chkUseCustom.Checked;
            cmdFolderSelect.Enabled = chkUseCustom.Checked;
        }
    }
}
