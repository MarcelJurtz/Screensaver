namespace Screensaver
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblCopyrightA = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.chkUseDefault = new System.Windows.Forms.CheckBox();
            this.chkUseCustom = new System.Windows.Forms.CheckBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.cmdFolderSelect = new System.Windows.Forms.Button();
            this.txtChangeInterval = new System.Windows.Forms.TextBox();
            this.lblChangeInterval = new System.Windows.Forms.Label();
            this.txtCustomText = new System.Windows.Forms.TextBox();
            this.lblCustomText = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cmdSelectColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCopyrightA
            // 
            this.lblCopyrightA.AutoSize = true;
            this.lblCopyrightA.Font = new System.Drawing.Font("Liberation Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrightA.ForeColor = System.Drawing.Color.Black;
            this.lblCopyrightA.Location = new System.Drawing.Point(78, 9);
            this.lblCopyrightA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyrightA.Name = "lblCopyrightA";
            this.lblCopyrightA.Size = new System.Drawing.Size(357, 36);
            this.lblCopyrightA.TabIndex = 0;
            this.lblCopyrightA.Text = "Slideshow Screen Saver";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.Black;
            this.cmdCancel.Location = new System.Drawing.Point(24, 226);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(222, 47);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Abbrechen";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Location = new System.Drawing.Point(264, 226);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(222, 47);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // chkUseDefault
            // 
            this.chkUseDefault.AutoSize = true;
            this.chkUseDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDefault.Location = new System.Drawing.Point(27, 49);
            this.chkUseDefault.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseDefault.Name = "chkUseDefault";
            this.chkUseDefault.Size = new System.Drawing.Size(203, 22);
            this.chkUseDefault.TabIndex = 7;
            this.chkUseDefault.Text = "Standard-Bilder verwenden";
            this.chkUseDefault.UseVisualStyleBackColor = true;
            this.chkUseDefault.CheckedChanged += new System.EventHandler(this.chkUseDefault_CheckedChanged);
            // 
            // chkUseCustom
            // 
            this.chkUseCustom.AutoSize = true;
            this.chkUseCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseCustom.Location = new System.Drawing.Point(24, 79);
            this.chkUseCustom.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseCustom.Name = "chkUseCustom";
            this.chkUseCustom.Size = new System.Drawing.Size(188, 22);
            this.chkUseCustom.TabIndex = 8;
            this.chkUseCustom.Text = "Eigene Bilder verwenden";
            this.chkUseCustom.UseVisualStyleBackColor = true;
            this.chkUseCustom.CheckedChanged += new System.EventHandler(this.chkUseCustom_CheckedChanged);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.Location = new System.Drawing.Point(24, 110);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(342, 24);
            this.txtFolderPath.TabIndex = 9;
            // 
            // cmdFolderSelect
            // 
            this.cmdFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFolderSelect.Location = new System.Drawing.Point(374, 109);
            this.cmdFolderSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmdFolderSelect.Name = "cmdFolderSelect";
            this.cmdFolderSelect.Size = new System.Drawing.Size(112, 27);
            this.cmdFolderSelect.TabIndex = 10;
            this.cmdFolderSelect.Text = "Auswählen";
            this.cmdFolderSelect.UseVisualStyleBackColor = true;
            this.cmdFolderSelect.Click += new System.EventHandler(this.cmdFolderSelect_Click);
            // 
            // txtChangeInterval
            // 
            this.txtChangeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeInterval.Location = new System.Drawing.Point(245, 144);
            this.txtChangeInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtChangeInterval.Name = "txtChangeInterval";
            this.txtChangeInterval.Size = new System.Drawing.Size(241, 24);
            this.txtChangeInterval.TabIndex = 11;
            this.txtChangeInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeInterval_KeyPress);
            // 
            // lblChangeInterval
            // 
            this.lblChangeInterval.AutoSize = true;
            this.lblChangeInterval.Location = new System.Drawing.Point(24, 147);
            this.lblChangeInterval.Name = "lblChangeInterval";
            this.lblChangeInterval.Size = new System.Drawing.Size(214, 18);
            this.lblChangeInterval.TabIndex = 12;
            this.lblChangeInterval.Text = "Wechselintervall (in Sekunden):";
            // 
            // txtCustomText
            // 
            this.txtCustomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomText.Location = new System.Drawing.Point(71, 177);
            this.txtCustomText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomText.Name = "txtCustomText";
            this.txtCustomText.Size = new System.Drawing.Size(295, 24);
            this.txtCustomText.TabIndex = 13;
            // 
            // lblCustomText
            // 
            this.lblCustomText.AutoSize = true;
            this.lblCustomText.Location = new System.Drawing.Point(21, 180);
            this.lblCustomText.Name = "lblCustomText";
            this.lblCustomText.Size = new System.Drawing.Size(40, 18);
            this.lblCustomText.TabIndex = 14;
            this.lblCustomText.Text = "Text:";
            // 
            // cmdSelectColor
            // 
            this.cmdSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectColor.Location = new System.Drawing.Point(374, 176);
            this.cmdSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectColor.Name = "cmdSelectColor";
            this.cmdSelectColor.Size = new System.Drawing.Size(112, 27);
            this.cmdSelectColor.TabIndex = 15;
            this.cmdSelectColor.Text = "Farbe";
            this.cmdSelectColor.UseVisualStyleBackColor = true;
            this.cmdSelectColor.Click += new System.EventHandler(this.cmdSelectColor_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(499, 286);
            this.Controls.Add(this.cmdSelectColor);
            this.Controls.Add(this.lblCustomText);
            this.Controls.Add(this.txtCustomText);
            this.Controls.Add(this.lblChangeInterval);
            this.Controls.Add(this.txtChangeInterval);
            this.Controls.Add(this.cmdFolderSelect);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.chkUseCustom);
            this.Controls.Add(this.chkUseDefault);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lblCopyrightA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyrightA;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.CheckBox chkUseDefault;
        private System.Windows.Forms.CheckBox chkUseCustom;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button cmdFolderSelect;
        private System.Windows.Forms.TextBox txtChangeInterval;
        private System.Windows.Forms.Label lblChangeInterval;
        private System.Windows.Forms.TextBox txtCustomText;
        private System.Windows.Forms.Label lblCustomText;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button cmdSelectColor;
    }
}