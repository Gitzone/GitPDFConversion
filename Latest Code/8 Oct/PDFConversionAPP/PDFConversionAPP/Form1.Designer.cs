﻿namespace PDFConversionAPP
{
    partial class Form1
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
            this.rootPanel = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.btnOutPath = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileNames = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblOutpath = new System.Windows.Forms.Label();
            this.rootPanel.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.Controls.Add(this.panelFill);
            this.rootPanel.Controls.Add(this.topPanel);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Size = new System.Drawing.Size(552, 282);
            this.rootPanel.TabIndex = 0;
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.Linen;
            this.panelFill.Controls.Add(this.lblOutpath);
            this.panelFill.Controls.Add(this.btnOutPath);
            this.panelFill.Controls.Add(this.progressBar1);
            this.panelFill.Controls.Add(this.label1);
            this.panelFill.Controls.Add(this.lblFileNames);
            this.panelFill.Controls.Add(this.btnConvert);
            this.panelFill.Controls.Add(this.btnBrowse);
            this.panelFill.Controls.Add(this.lblSelect);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 54);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(552, 228);
            this.panelFill.TabIndex = 1;
            // 
            // btnOutPath
            // 
            this.btnOutPath.Location = new System.Drawing.Point(213, 82);
            this.btnOutPath.Name = "btnOutPath";
            this.btnOutPath.Size = new System.Drawing.Size(75, 23);
            this.btnOutPath.TabIndex = 7;
            this.btnOutPath.Text = "Output Path";
            this.btnOutPath.UseVisualStyleBackColor = true;
            this.btnOutPath.Click += new System.EventHandler(this.btnOutPath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(125, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note: Only JPEG,JPG,TEXT,GIF,DOC,DOCX,XLSX,XLS, File formats are accepted.";
            // 
            // lblFileNames
            // 
            this.lblFileNames.AutoSize = true;
            this.lblFileNames.Location = new System.Drawing.Point(306, 48);
            this.lblFileNames.Name = "lblFileNames";
            this.lblFileNames.Size = new System.Drawing.Size(54, 13);
            this.lblFileNames.TabIndex = 4;
            this.lblFileNames.Text = "File Name";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(213, 152);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(213, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(76, 46);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(99, 17);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Files:";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Linen;
            this.topPanel.Controls.Add(this.lblHeading);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(552, 54);
            this.topPanel.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(121, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(275, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Upload Files For PDF Conversion";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // lblOutpath
            // 
            this.lblOutpath.AutoSize = true;
            this.lblOutpath.Location = new System.Drawing.Point(306, 92);
            this.lblOutpath.Name = "lblOutpath";
            this.lblOutpath.Size = new System.Drawing.Size(0, 13);
            this.lblOutpath.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(552, 282);
            this.Controls.Add(this.rootPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Conversion Window";
            this.rootPanel.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rootPanel;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileNames;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOutPath;
        private System.Windows.Forms.Label lblOutpath;
    }
}

