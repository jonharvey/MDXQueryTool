namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    partial class frmPrefs
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
            this.lblAutoSave = new System.Windows.Forms.Label();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.txtAutoFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ofdAutoFile = new System.Windows.Forms.OpenFileDialog();
            this.lblMbrDisplay = new System.Windows.Forms.Label();
            this.cboMbrDisplay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAutoSave
            // 
            this.lblAutoSave.AutoSize = true;
            this.lblAutoSave.Location = new System.Drawing.Point(53, 32);
            this.lblAutoSave.Name = "lblAutoSave";
            this.lblAutoSave.Size = new System.Drawing.Size(63, 13);
            this.lblAutoSave.TabIndex = 0;
            this.lblAutoSave.Text = "Auto-Save?";
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Location = new System.Drawing.Point(123, 32);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(15, 14);
            this.chkAutoSave.TabIndex = 1;
            this.chkAutoSave.UseVisualStyleBackColor = true;
            this.chkAutoSave.CheckedChanged += new System.EventHandler(this.chkAutoSave_CheckedChanged);
            // 
            // txtAutoFile
            // 
            this.txtAutoFile.Enabled = false;
            this.txtAutoFile.Location = new System.Drawing.Point(144, 29);
            this.txtAutoFile.Name = "txtAutoFile";
            this.txtAutoFile.Size = new System.Drawing.Size(265, 20);
            this.txtAutoFile.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(415, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 20);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(144, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ofdAutoFile
            // 
            this.ofdAutoFile.FileName = "autosave";
            this.ofdAutoFile.Filter = "Config Files (*.cfg)|*.cfg";
            this.ofdAutoFile.Title = "Select Auto-Save location...";
            // 
            // lblMbrDisplay
            // 
            this.lblMbrDisplay.AutoSize = true;
            this.lblMbrDisplay.Location = new System.Drawing.Point(50, 73);
            this.lblMbrDisplay.Name = "lblMbrDisplay";
            this.lblMbrDisplay.Size = new System.Drawing.Size(88, 13);
            this.lblMbrDisplay.TabIndex = 8;
            this.lblMbrDisplay.Text = "Member Display :";
            // 
            // cboMbrDisplay
            // 
            this.cboMbrDisplay.FormattingEnabled = true;
            this.cboMbrDisplay.Items.AddRange(new object[] {
            "NAME",
            "ALIAS"});
            this.cboMbrDisplay.Location = new System.Drawing.Point(144, 70);
            this.cboMbrDisplay.Name = "cboMbrDisplay";
            this.cboMbrDisplay.Size = new System.Drawing.Size(145, 21);
            this.cboMbrDisplay.TabIndex = 9;
            // 
            // frmPrefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 142);
            this.Controls.Add(this.cboMbrDisplay);
            this.Controls.Add(this.lblMbrDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtAutoFile);
            this.Controls.Add(this.chkAutoSave);
            this.Controls.Add(this.lblAutoSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrefs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPrefs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoSave;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.TextBox txtAutoFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog ofdAutoFile;
        private System.Windows.Forms.Label lblMbrDisplay;
        private System.Windows.Forms.ComboBox cboMbrDisplay;
    }
}