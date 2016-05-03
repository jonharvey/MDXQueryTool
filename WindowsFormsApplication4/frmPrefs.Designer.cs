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
            this.lblMbrDisplay = new System.Windows.Forms.Label();
            this.cboMbrDisplay = new System.Windows.Forms.ComboBox();
            this.btnOFDQueryHist = new System.Windows.Forms.Button();
            this.txtQueryHistFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sfdAutoFile = new System.Windows.Forms.SaveFileDialog();
            this.sfdQueryHist = new System.Windows.Forms.SaveFileDialog();
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
            this.btnClose.Location = new System.Drawing.Point(144, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMbrDisplay
            // 
            this.lblMbrDisplay.AutoSize = true;
            this.lblMbrDisplay.Location = new System.Drawing.Point(50, 104);
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
            this.cboMbrDisplay.Location = new System.Drawing.Point(144, 101);
            this.cboMbrDisplay.Name = "cboMbrDisplay";
            this.cboMbrDisplay.Size = new System.Drawing.Size(145, 21);
            this.cboMbrDisplay.TabIndex = 9;
            // 
            // btnOFDQueryHist
            // 
            this.btnOFDQueryHist.Location = new System.Drawing.Point(415, 64);
            this.btnOFDQueryHist.Name = "btnOFDQueryHist";
            this.btnOFDQueryHist.Size = new System.Drawing.Size(28, 20);
            this.btnOFDQueryHist.TabIndex = 12;
            this.btnOFDQueryHist.Text = "...";
            this.btnOFDQueryHist.UseVisualStyleBackColor = true;
            this.btnOFDQueryHist.Click += new System.EventHandler(this.btnOFDQueryHist_Click);
            // 
            // txtQueryHistFile
            // 
            this.txtQueryHistFile.Location = new System.Drawing.Point(144, 64);
            this.txtQueryHistFile.Name = "txtQueryHistFile";
            this.txtQueryHistFile.Size = new System.Drawing.Size(265, 20);
            this.txtQueryHistFile.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Query history file :";
            // 
            // sfdAutoFile
            // 
            this.sfdAutoFile.DefaultExt = "cfg";
            this.sfdAutoFile.FileName = "autosave";
            this.sfdAutoFile.Filter = "Config Files (*.cfg)|*.cfg";
            this.sfdAutoFile.Title = "Select Auto-Save location...";
            // 
            // sfdQueryHist
            // 
            this.sfdQueryHist.DefaultExt = "xml";
            this.sfdQueryHist.FileName = "query_hist";
            this.sfdQueryHist.Filter = "XML Files (*.xml)|*.xml";
            this.sfdQueryHist.Title = "Select location of query history file...";
            // 
            // frmPrefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 179);
            this.Controls.Add(this.btnOFDQueryHist);
            this.Controls.Add(this.txtQueryHistFile);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label lblMbrDisplay;
        private System.Windows.Forms.ComboBox cboMbrDisplay;
        private System.Windows.Forms.Button btnOFDQueryHist;
        private System.Windows.Forms.TextBox txtQueryHistFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdAutoFile;
        private System.Windows.Forms.SaveFileDialog sfdQueryHist;
    }
}