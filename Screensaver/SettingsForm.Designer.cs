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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.cmdFolderSelect = new System.Windows.Forms.Button();
            this.txtCustomText = new System.Windows.Forms.TextBox();
            this.lblCustomText = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cmdSelectColor = new System.Windows.Forms.Button();
            this.chkShowDateTime = new System.Windows.Forms.CheckBox();
            this.chkShowText = new System.Windows.Forms.CheckBox();
            this.ofdImageSelector = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblCopyrightA
            // 
            this.lblCopyrightA.AutoSize = true;
            this.lblCopyrightA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrightA.ForeColor = System.Drawing.Color.Black;
            this.lblCopyrightA.Location = new System.Drawing.Point(13, 9);
            this.lblCopyrightA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyrightA.Name = "lblCopyrightA";
            this.lblCopyrightA.Size = new System.Drawing.Size(194, 37);
            this.lblCopyrightA.TabIndex = 0;
            this.lblCopyrightA.Text = "Screensaver";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.Black;
            this.cmdCancel.Location = new System.Drawing.Point(13, 171);
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
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Location = new System.Drawing.Point(264, 171);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(222, 47);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.Location = new System.Drawing.Point(13, 50);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(342, 24);
            this.txtFolderPath.TabIndex = 9;
            // 
            // cmdFolderSelect
            // 
            this.cmdFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFolderSelect.Location = new System.Drawing.Point(374, 50);
            this.cmdFolderSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmdFolderSelect.Name = "cmdFolderSelect";
            this.cmdFolderSelect.Size = new System.Drawing.Size(112, 27);
            this.cmdFolderSelect.TabIndex = 10;
            this.cmdFolderSelect.Text = "Auswählen";
            this.cmdFolderSelect.UseVisualStyleBackColor = true;
            this.cmdFolderSelect.Click += new System.EventHandler(this.cmdFolderSelect_Click);
            // 
            // txtCustomText
            // 
            this.txtCustomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomText.Location = new System.Drawing.Point(60, 82);
            this.txtCustomText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomText.Name = "txtCustomText";
            this.txtCustomText.Size = new System.Drawing.Size(295, 24);
            this.txtCustomText.TabIndex = 13;
            // 
            // lblCustomText
            // 
            this.lblCustomText.AutoSize = true;
            this.lblCustomText.Location = new System.Drawing.Point(12, 85);
            this.lblCustomText.Name = "lblCustomText";
            this.lblCustomText.Size = new System.Drawing.Size(40, 18);
            this.lblCustomText.TabIndex = 14;
            this.lblCustomText.Text = "Text:";
            // 
            // cmdSelectColor
            // 
            this.cmdSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectColor.Location = new System.Drawing.Point(374, 82);
            this.cmdSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectColor.Name = "cmdSelectColor";
            this.cmdSelectColor.Size = new System.Drawing.Size(112, 27);
            this.cmdSelectColor.TabIndex = 15;
            this.cmdSelectColor.Text = "Farbe";
            this.cmdSelectColor.UseVisualStyleBackColor = true;
            this.cmdSelectColor.Click += new System.EventHandler(this.cmdSelectColor_Click);
            // 
            // chkShowDateTime
            // 
            this.chkShowDateTime.AutoSize = true;
            this.chkShowDateTime.Location = new System.Drawing.Point(13, 113);
            this.chkShowDateTime.Name = "chkShowDateTime";
            this.chkShowDateTime.Size = new System.Drawing.Size(137, 22);
            this.chkShowDateTime.TabIndex = 16;
            this.chkShowDateTime.Text = "Uhrzeit anzeigen";
            this.chkShowDateTime.UseVisualStyleBackColor = true;
            // 
            // chkShowText
            // 
            this.chkShowText.AutoSize = true;
            this.chkShowText.Location = new System.Drawing.Point(13, 142);
            this.chkShowText.Name = "chkShowText";
            this.chkShowText.Size = new System.Drawing.Size(118, 22);
            this.chkShowText.TabIndex = 17;
            this.chkShowText.Text = "Text anzeigen";
            this.chkShowText.UseVisualStyleBackColor = true;
            // 
            // ofdImageSelector
            // 
            this.ofdImageSelector.FileName = "openFileDialog1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(499, 228);
            this.Controls.Add(this.chkShowText);
            this.Controls.Add(this.chkShowDateTime);
            this.Controls.Add(this.cmdSelectColor);
            this.Controls.Add(this.lblCustomText);
            this.Controls.Add(this.txtCustomText);
            this.Controls.Add(this.cmdFolderSelect);
            this.Controls.Add(this.txtFolderPath);
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
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button cmdFolderSelect;
        private System.Windows.Forms.TextBox txtCustomText;
        private System.Windows.Forms.Label lblCustomText;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button cmdSelectColor;
        private System.Windows.Forms.CheckBox chkShowDateTime;
        private System.Windows.Forms.CheckBox chkShowText;
        private System.Windows.Forms.OpenFileDialog ofdImageSelector;
    }
}