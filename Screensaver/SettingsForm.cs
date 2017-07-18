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

        String imgPath;
        bool showText;
        bool showDateTime;
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
                imgPath = "";
                customText = "";
                customTextColor = Color.Black.ToString();
            }
            else
            {
                try
                {
                    // Registry-Settings
                    imgPath = (string)key.GetValue("imagepath");
                    customText = (string)key.GetValue("customText");
                    customTextColor = (string)key.GetValue("customTextColor");
                    showText = Convert.ToBoolean((string)key.GetValue("showText")); ;
                    showDateTime = Convert.ToBoolean((string)key.GetValue("showDateTime"));
                }
                catch(Exception ex)
                {
                    // Called when one of the Registry-Values is not available
                    // Just Re-Saving should fix it
                }
            }

            if (!File.Exists(imgPath))
            {
                imgPath = "";
            }

            txtFolderPath.Text = imgPath;
            txtCustomText.Text = customText;
            chkShowDateTime.Checked = showDateTime;
            chkShowText.Checked = showText;
            ofdImageSelector.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";
            ofdImageSelector.FileName = "";
        }

        // Create and set Registry-Key
        private void saveKey()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MJScreenSaver");
            key.SetValue("imagepath", txtFolderPath.Text);
            key.SetValue("showText", chkShowText.Checked);
            key.SetValue("showDateTime", chkShowDateTime.Checked);
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
            if (txtFolderPath.Text == "" || !File.Exists(txtFolderPath.Text)) MessageBox.Show("Kein Pfad für Bilder festgelegt.\nBitte füge einen Pfad ein.", "Fehler beim Speicher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                saveKey();
                Close();
            }            
        }

        private void cmdFolderSelect_Click(object sender, EventArgs e)
        {
            if (ofdImageSelector.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = ofdImageSelector.FileName;
            }
        }

        private void cmdSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                customTextColor = colorDialog.Color.ToArgb().ToString();
        }
    }
}
