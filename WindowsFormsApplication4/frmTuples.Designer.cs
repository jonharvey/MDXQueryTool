namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    partial class frmTuples
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
            this.lboTuples = new System.Windows.Forms.ListBox();
            this.lblDimTuples = new System.Windows.Forms.Label();
            this.lboDimensions = new System.Windows.Forms.ListBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.btnAddTuple = new System.Windows.Forms.Button();
            this.btnRemoveTuple = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUpdateTuple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboTuples
            // 
            this.lboTuples.FormattingEnabled = true;
            this.lboTuples.Location = new System.Drawing.Point(21, 37);
            this.lboTuples.Name = "lboTuples";
            this.lboTuples.Size = new System.Drawing.Size(113, 134);
            this.lboTuples.TabIndex = 0;
            this.lboTuples.SelectedIndexChanged += new System.EventHandler(this.lboTuples_SelectedIndexChanged);
            // 
            // lblDimTuples
            // 
            this.lblDimTuples.AutoSize = true;
            this.lblDimTuples.Location = new System.Drawing.Point(21, 18);
            this.lblDimTuples.Name = "lblDimTuples";
            this.lblDimTuples.Size = new System.Drawing.Size(83, 13);
            this.lblDimTuples.TabIndex = 1;
            this.lblDimTuples.Text = "Column Tuples :";
            // 
            // lboDimensions
            // 
            this.lboDimensions.Enabled = false;
            this.lboDimensions.FormattingEnabled = true;
            this.lboDimensions.Location = new System.Drawing.Point(154, 37);
            this.lboDimensions.Name = "lboDimensions";
            this.lboDimensions.Size = new System.Drawing.Size(120, 199);
            this.lboDimensions.TabIndex = 2;
            this.lboDimensions.SelectedIndexChanged += new System.EventHandler(this.lboDimensions_SelectedIndexChanged);
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Enabled = false;
            this.lblDimensions.Location = new System.Drawing.Point(151, 18);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(67, 13);
            this.lblDimensions.TabIndex = 3;
            this.lblDimensions.Text = "Dimensions :";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Enabled = false;
            this.lblSelection.Location = new System.Drawing.Point(292, 48);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(57, 13);
            this.lblSelection.TabIndex = 4;
            this.lblSelection.Text = "Selection :";
            // 
            // txtSelection
            // 
            this.txtSelection.Enabled = false;
            this.txtSelection.Location = new System.Drawing.Point(295, 64);
            this.txtSelection.Multiline = true;
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(319, 143);
            this.txtSelection.TabIndex = 5;
            // 
            // btnAddTuple
            // 
            this.btnAddTuple.Location = new System.Drawing.Point(21, 184);
            this.btnAddTuple.Name = "btnAddTuple";
            this.btnAddTuple.Size = new System.Drawing.Size(113, 23);
            this.btnAddTuple.TabIndex = 6;
            this.btnAddTuple.Text = "Add New";
            this.btnAddTuple.UseVisualStyleBackColor = true;
            this.btnAddTuple.Click += new System.EventHandler(this.btnAddTuple_Click);
            // 
            // btnRemoveTuple
            // 
            this.btnRemoveTuple.Enabled = false;
            this.btnRemoveTuple.Location = new System.Drawing.Point(21, 213);
            this.btnRemoveTuple.Name = "btnRemoveTuple";
            this.btnRemoveTuple.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveTuple.TabIndex = 7;
            this.btnRemoveTuple.Text = "Remove";
            this.btnRemoveTuple.UseVisualStyleBackColor = true;
            this.btnRemoveTuple.Click += new System.EventHandler(this.btnRemoveTuple_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Enabled = false;
            this.btnSelection.Location = new System.Drawing.Point(295, 213);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(107, 23);
            this.btnSelection.TabIndex = 8;
            this.btnSelection.Text = "Member Selection";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(537, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "&Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUpdateTuple
            // 
            this.btnUpdateTuple.Enabled = false;
            this.btnUpdateTuple.Location = new System.Drawing.Point(505, 213);
            this.btnUpdateTuple.Name = "btnUpdateTuple";
            this.btnUpdateTuple.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateTuple.TabIndex = 10;
            this.btnUpdateTuple.Text = "Update Tuple";
            this.btnUpdateTuple.UseVisualStyleBackColor = true;
            this.btnUpdateTuple.Click += new System.EventHandler(this.btnUpdateTuple_Click);
            // 
            // frmTuples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 248);
            this.Controls.Add(this.btnUpdateTuple);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnRemoveTuple);
            this.Controls.Add(this.btnAddTuple);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.lboDimensions);
            this.Controls.Add(this.lblDimTuples);
            this.Controls.Add(this.lboTuples);
            this.Name = "frmTuples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuple Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboTuples;
        private System.Windows.Forms.Label lblDimTuples;
        private System.Windows.Forms.ListBox lboDimensions;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.Button btnAddTuple;
        private System.Windows.Forms.Button btnRemoveTuple;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUpdateTuple;
    }
}