namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    partial class frmQueryHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryHistory));
            this.scintQry = new ScintillaNET.Scintilla();
            this.bindnavQuerySet = new System.Windows.Forms.BindingNavigator(this.components);
            this.binddsQueryHist = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblExecBy = new System.Windows.Forms.Label();
            this.lblExecTime = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblExecDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindnavQuerySet)).BeginInit();
            this.bindnavQuerySet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binddsQueryHist)).BeginInit();
            this.SuspendLayout();
            // 
            // scintQry
            // 
            this.scintQry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintQry.Lexer = ScintillaNET.Lexer.Null;
            this.scintQry.Location = new System.Drawing.Point(13, 13);
            this.scintQry.Name = "scintQry";
            this.scintQry.ScrollWidth = 450;
            this.scintQry.Size = new System.Drawing.Size(598, 276);
            this.scintQry.TabIndex = 2;
            this.scintQry.StyleNeeded += new System.EventHandler<ScintillaNET.StyleNeededEventArgs>(this.scintQry_StyleNeeded);
            this.scintQry.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintQry_UpdateUI);
            this.scintQry.TextChanged += new System.EventHandler(this.scintQry_TextChanged);
            this.scintQry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQueryHistory_KeyDown);
            // 
            // bindnavQuerySet
            // 
            this.bindnavQuerySet.AddNewItem = null;
            this.bindnavQuerySet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindnavQuerySet.BindingSource = this.binddsQueryHist;
            this.bindnavQuerySet.CountItem = this.bindingNavigatorCountItem;
            this.bindnavQuerySet.DeleteItem = null;
            this.bindnavQuerySet.Dock = System.Windows.Forms.DockStyle.None;
            this.bindnavQuerySet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindnavQuerySet.Location = new System.Drawing.Point(15, 292);
            this.bindnavQuerySet.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindnavQuerySet.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindnavQuerySet.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindnavQuerySet.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindnavQuerySet.Name = "bindnavQuerySet";
            this.bindnavQuerySet.PositionItem = this.bindingNavigatorPositionItem;
            this.bindnavQuerySet.Size = new System.Drawing.Size(209, 25);
            this.bindnavQuerySet.TabIndex = 3;
            this.bindnavQuerySet.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblExecBy
            // 
            this.lblExecBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExecBy.AutoSize = true;
            this.lblExecBy.Location = new System.Drawing.Point(256, 330);
            this.lblExecBy.Name = "lblExecBy";
            this.lblExecBy.Size = new System.Drawing.Size(95, 13);
            this.lblExecBy.TabIndex = 5;
            this.lblExecBy.Text = "Executed by user :";
            // 
            // lblExecTime
            // 
            this.lblExecTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExecTime.AutoSize = true;
            this.lblExecTime.Location = new System.Drawing.Point(12, 330);
            this.lblExecTime.Name = "lblExecTime";
            this.lblExecTime.Size = new System.Drawing.Size(63, 13);
            this.lblExecTime.TabIndex = 6;
            this.lblExecTime.Text = "Executed in";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(452, 294);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(533, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(348, 330);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(27, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "jdoe";
            // 
            // lblExecDate
            // 
            this.lblExecDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExecDate.AutoSize = true;
            this.lblExecDate.Location = new System.Drawing.Point(497, 330);
            this.lblExecDate.Name = "lblExecDate";
            this.lblExecDate.Size = new System.Drawing.Size(102, 13);
            this.lblExecDate.TabIndex = 11;
            this.lblExecDate.Text = "05/03/16 03:20 PM";
            this.lblExecDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmQueryHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 352);
            this.Controls.Add(this.lblExecDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblExecTime);
            this.Controls.Add(this.lblExecBy);
            this.Controls.Add(this.bindnavQuerySet);
            this.Controls.Add(this.scintQry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQueryHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Previously Executed Queries";
            this.Load += new System.EventHandler(this.frmQueryHistory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQueryHistory_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindnavQuerySet)).EndInit();
            this.bindnavQuerySet.ResumeLayout(false);
            this.bindnavQuerySet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binddsQueryHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla scintQry;
        private System.Windows.Forms.BindingNavigator bindnavQuerySet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource binddsQueryHist;
        private System.Windows.Forms.Label lblExecBy;
        private System.Windows.Forms.Label lblExecTime;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblExecDate;
    }
}