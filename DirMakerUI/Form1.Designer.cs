namespace DirMakerUI
{
    partial class MainForm
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
            this.btnDestinationDirBrowse = new System.Windows.Forms.Button();
            this.btnTextFileSourceDir = new System.Windows.Forms.Button();
            this.pnlDestinationLabel = new System.Windows.Forms.Panel();
            this.lblDestinationDir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextConfigPath = new System.Windows.Forms.Label();
            this.textbUserDefinedConfig = new System.Windows.Forms.TextBox();
            this.treevLoadedConfig = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDestinationLabel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDestinationDirBrowse
            // 
            this.btnDestinationDirBrowse.Location = new System.Drawing.Point(423, 372);
            this.btnDestinationDirBrowse.Name = "btnDestinationDirBrowse";
            this.btnDestinationDirBrowse.Size = new System.Drawing.Size(56, 34);
            this.btnDestinationDirBrowse.TabIndex = 0;
            this.btnDestinationDirBrowse.Text = "Browse";
            this.btnDestinationDirBrowse.UseVisualStyleBackColor = true;
            // 
            // btnTextFileSourceDir
            // 
            this.btnTextFileSourceDir.Location = new System.Drawing.Point(423, 312);
            this.btnTextFileSourceDir.Name = "btnTextFileSourceDir";
            this.btnTextFileSourceDir.Size = new System.Drawing.Size(56, 34);
            this.btnTextFileSourceDir.TabIndex = 1;
            this.btnTextFileSourceDir.Text = "Browse";
            this.btnTextFileSourceDir.UseVisualStyleBackColor = true;
            // 
            // pnlDestinationLabel
            // 
            this.pnlDestinationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDestinationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDestinationLabel.Controls.Add(this.lblDestinationDir);
            this.pnlDestinationLabel.Location = new System.Drawing.Point(99, 372);
            this.pnlDestinationLabel.Name = "pnlDestinationLabel";
            this.pnlDestinationLabel.Size = new System.Drawing.Size(318, 34);
            this.pnlDestinationLabel.TabIndex = 2;
            // 
            // lblDestinationDir
            // 
            this.lblDestinationDir.AutoSize = true;
            this.lblDestinationDir.Location = new System.Drawing.Point(3, 11);
            this.lblDestinationDir.Name = "lblDestinationDir";
            this.lblDestinationDir.Size = new System.Drawing.Size(105, 13);
            this.lblDestinationDir.TabIndex = 0;
            this.lblDestinationDir.Text = "Destination Directory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTextConfigPath);
            this.panel1.Location = new System.Drawing.Point(99, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 34);
            this.panel1.TabIndex = 3;
            // 
            // lblTextConfigPath
            // 
            this.lblTextConfigPath.AutoSize = true;
            this.lblTextConfigPath.Location = new System.Drawing.Point(3, 11);
            this.lblTextConfigPath.Name = "lblTextConfigPath";
            this.lblTextConfigPath.Size = new System.Drawing.Size(80, 13);
            this.lblTextConfigPath.TabIndex = 0;
            this.lblTextConfigPath.Text = "Text Config File";
            // 
            // textbUserDefinedConfig
            // 
            this.textbUserDefinedConfig.AcceptsReturn = true;
            this.textbUserDefinedConfig.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbUserDefinedConfig.Location = new System.Drawing.Point(99, 58);
            this.textbUserDefinedConfig.Multiline = true;
            this.textbUserDefinedConfig.Name = "textbUserDefinedConfig";
            this.textbUserDefinedConfig.Size = new System.Drawing.Size(229, 200);
            this.textbUserDefinedConfig.TabIndex = 4;
            // 
            // treevLoadedConfig
            // 
            this.treevLoadedConfig.Location = new System.Drawing.Point(728, 73);
            this.treevLoadedConfig.Name = "treevLoadedConfig";
            this.treevLoadedConfig.Size = new System.Drawing.Size(165, 200);
            this.treevLoadedConfig.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dir Maker";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treevLoadedConfig);
            this.Controls.Add(this.textbUserDefinedConfig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDestinationLabel);
            this.Controls.Add(this.btnTextFileSourceDir);
            this.Controls.Add(this.btnDestinationDirBrowse);
            this.Name = "MainForm";
            this.Text = "Make Dir";
            this.pnlDestinationLabel.ResumeLayout(false);
            this.pnlDestinationLabel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDestinationDirBrowse;
        private System.Windows.Forms.Button btnTextFileSourceDir;
        private System.Windows.Forms.Panel pnlDestinationLabel;
        private System.Windows.Forms.Label lblDestinationDir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextConfigPath;
        private System.Windows.Forms.TextBox textbUserDefinedConfig;
        private System.Windows.Forms.TreeView treevLoadedConfig;
        private System.Windows.Forms.Button button1;
    }
}

