namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    partial class frmQueryLayout
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
            this.components = new System.ComponentModel.Container();
            this.lboDimensions = new System.Windows.Forms.ListBox();
            this.lboColumns = new System.Windows.Forms.ListBox();
            this.lboRows = new System.Windows.Forms.ListBox();
            this.lboSlicer = new System.Windows.Forms.ListBox();
            this.lblDims = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblSlicer = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tipLayout = new System.Windows.Forms.ToolTip(this.components);
            this.errLayout = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lboDimensions
            // 
            this.lboDimensions.AllowDrop = true;
            this.lboDimensions.FormattingEnabled = true;
            this.lboDimensions.Location = new System.Drawing.Point(12, 33);
            this.lboDimensions.Name = "lboDimensions";
            this.lboDimensions.Size = new System.Drawing.Size(120, 264);
            this.lboDimensions.TabIndex = 0;
            // 
            // lboColumns
            // 
            this.lboColumns.AllowDrop = true;
            this.lboColumns.FormattingEnabled = true;
            this.lboColumns.Location = new System.Drawing.Point(289, 63);
            this.lboColumns.Name = "lboColumns";
            this.lboColumns.Size = new System.Drawing.Size(113, 108);
            this.lboColumns.TabIndex = 1;
            this.tipLayout.SetToolTip(this.lboColumns, "Dimensions placed here will show up in the column header. ");
            // 
            // lboRows
            // 
            this.lboRows.AllowDrop = true;
            this.lboRows.FormattingEnabled = true;
            this.lboRows.Location = new System.Drawing.Point(166, 174);
            this.lboRows.Name = "lboRows";
            this.lboRows.Size = new System.Drawing.Size(120, 121);
            this.lboRows.TabIndex = 2;
            this.tipLayout.SetToolTip(this.lboRows, "Dimensions placed here will show up in the row header. ");
            // 
            // lboSlicer
            // 
            this.lboSlicer.AllowDrop = true;
            this.lboSlicer.FormattingEnabled = true;
            this.lboSlicer.Location = new System.Drawing.Point(411, 174);
            this.lboSlicer.Name = "lboSlicer";
            this.lboSlicer.Size = new System.Drawing.Size(120, 121);
            this.lboSlicer.TabIndex = 3;
            this.tipLayout.SetToolTip(this.lboSlicer, "A slicer is like a WHERE clause.  These are the fixed, or POV dimensions.  ");
            // 
            // lblDims
            // 
            this.lblDims.AutoSize = true;
            this.lblDims.Location = new System.Drawing.Point(9, 17);
            this.lblDims.Name = "lblDims";
            this.lblDims.Size = new System.Drawing.Size(67, 13);
            this.lblDims.TabIndex = 4;
            this.lblDims.Text = "Dimensions :";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(163, 158);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(40, 13);
            this.lblRows.TabIndex = 5;
            this.lblRows.Text = "Rows :";
            this.tipLayout.SetToolTip(this.lblRows, "Dimensions placed here will show up in the row header. ");
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(286, 47);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(53, 13);
            this.lblColumns.TabIndex = 6;
            this.lblColumns.Text = "Columns :";
            this.tipLayout.SetToolTip(this.lblColumns, "Dimensions placed here will show up in the column header. ");
            // 
            // lblSlicer
            // 
            this.lblSlicer.AutoSize = true;
            this.lblSlicer.Location = new System.Drawing.Point(408, 158);
            this.lblSlicer.Name = "lblSlicer";
            this.lblSlicer.Size = new System.Drawing.Size(39, 13);
            this.lblSlicer.TabIndex = 7;
            this.lblSlicer.Text = "Slicer :";
            this.tipLayout.SetToolTip(this.lblSlicer, "A slicer is like a WHERE clause.  These are the fixed, or POV dimensions.  \r\nDime" +
                    "nsions placed here will not display on rows or columns, but can be fixed to a sp" +
                    "ecific member.");
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(478, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "&Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tipLayout
            // 
            this.tipLayout.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipLayout.ToolTipTitle = "Slicer";
            // 
            // errLayout
            // 
            this.errLayout.ContainerControl = this;
            // 
            // frmQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 321);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lboDimensions);
            this.Controls.Add(this.lboColumns);
            this.Controls.Add(this.lblDims);
            this.Controls.Add(this.lboRows);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblSlicer);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lboSlicer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQueryBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Layout";
            this.Load += new System.EventHandler(this.frmQueryBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboDimensions;
        private System.Windows.Forms.ListBox lboColumns;
        private System.Windows.Forms.ListBox lboRows;
        private System.Windows.Forms.ListBox lboSlicer;
        private System.Windows.Forms.Label lblDims;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblSlicer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolTip tipLayout;
        private System.Windows.Forms.ErrorProvider errLayout;
    }
}