namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    partial class frmMbrSelection
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
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.nudDescSelection = new System.Windows.Forms.NumericUpDown();
            this.cboDescSelection = new System.Windows.Forms.ComboBox();
            this.rdoDescendants = new System.Windows.Forms.RadioButton();
            this.rdoMember = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.nudDescSelection);
            this.grpOptions.Controls.Add(this.cboDescSelection);
            this.grpOptions.Controls.Add(this.rdoDescendants);
            this.grpOptions.Controls.Add(this.rdoMember);
            this.grpOptions.Location = new System.Drawing.Point(417, 8);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(302, 90);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Selection Options";
            // 
            // nudDescSelection
            // 
            this.nudDescSelection.Enabled = false;
            this.nudDescSelection.Location = new System.Drawing.Point(250, 50);
            this.nudDescSelection.Name = "nudDescSelection";
            this.nudDescSelection.Size = new System.Drawing.Size(41, 20);
            this.nudDescSelection.TabIndex = 5;
            // 
            // cboDescSelection
            // 
            this.cboDescSelection.Enabled = false;
            this.cboDescSelection.FormattingEnabled = true;
            this.cboDescSelection.Items.AddRange(new object[] {
            "All",
            "At Level",
            "At Generation"});
            this.cboDescSelection.Location = new System.Drawing.Point(123, 50);
            this.cboDescSelection.Name = "cboDescSelection";
            this.cboDescSelection.Size = new System.Drawing.Size(121, 21);
            this.cboDescSelection.TabIndex = 4;
            this.cboDescSelection.Text = "All";
            // 
            // rdoDescendants
            // 
            this.rdoDescendants.AutoSize = true;
            this.rdoDescendants.Location = new System.Drawing.Point(18, 51);
            this.rdoDescendants.Name = "rdoDescendants";
            this.rdoDescendants.Size = new System.Drawing.Size(88, 17);
            this.rdoDescendants.TabIndex = 3;
            this.rdoDescendants.Text = "Descendants";
            this.rdoDescendants.UseVisualStyleBackColor = true;
            // 
            // rdoMember
            // 
            this.rdoMember.AutoSize = true;
            this.rdoMember.Checked = true;
            this.rdoMember.Location = new System.Drawing.Point(18, 28);
            this.rdoMember.Name = "rdoMember";
            this.rdoMember.Size = new System.Drawing.Size(63, 17);
            this.rdoMember.TabIndex = 0;
            this.rdoMember.TabStop = true;
            this.rdoMember.Text = "Member";
            this.rdoMember.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(8, 9);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(402, 487);
            this.treeView1.TabIndex = 2;
            // 
            // frmMbrSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 512);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpOptions);
            this.Name = "frmMbrSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Selection";
            this.Load += new System.EventHandler(this.frmMbrSelection_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.NumericUpDown nudDescSelection;
        private System.Windows.Forms.ComboBox cboDescSelection;
        private System.Windows.Forms.RadioButton rdoDescendants;
        private System.Windows.Forms.RadioButton rdoMember;
        private System.Windows.Forms.TreeView treeView1;
    }
}