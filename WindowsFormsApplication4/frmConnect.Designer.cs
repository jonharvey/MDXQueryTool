namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    partial class frmConnect
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
            this.txtEssServer = new System.Windows.Forms.TextBox();
            this.lblEssbase = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblAppDB = new System.Windows.Forms.Label();
            this.cboAppDB = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtAPS = new System.Windows.Forms.TextBox();
            this.lblAPS = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEssServer
            // 
            this.txtEssServer.Location = new System.Drawing.Point(119, 22);
            this.txtEssServer.Name = "txtEssServer";
            this.txtEssServer.Size = new System.Drawing.Size(102, 20);
            this.txtEssServer.TabIndex = 24;
            // 
            // lblEssbase
            // 
            this.lblEssbase.AutoSize = true;
            this.lblEssbase.Location = new System.Drawing.Point(24, 25);
            this.lblEssbase.Name = "lblEssbase";
            this.lblEssbase.Size = new System.Drawing.Size(87, 13);
            this.lblEssbase.TabIndex = 31;
            this.lblEssbase.Text = "Essbase Server :";
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(93, 252);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblAppDB
            // 
            this.lblAppDB.AutoSize = true;
            this.lblAppDB.Enabled = false;
            this.lblAppDB.Location = new System.Drawing.Point(28, 211);
            this.lblAppDB.Name = "lblAppDB";
            this.lblAppDB.Size = new System.Drawing.Size(58, 13);
            this.lblAppDB.TabIndex = 35;
            this.lblAppDB.Text = "App / DB :";
            // 
            // cboAppDB
            // 
            this.cboAppDB.Enabled = false;
            this.cboAppDB.FormattingEnabled = true;
            this.cboAppDB.Location = new System.Drawing.Point(93, 208);
            this.cboAppDB.Name = "cboAppDB";
            this.cboAppDB.Size = new System.Drawing.Size(151, 21);
            this.cboAppDB.TabIndex = 29;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(72, 159);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(115, 23);
            this.btnList.TabIndex = 28;
            this.btnList.Text = "Get App/DB List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(119, 118);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(102, 20);
            this.txtPW.TabIndex = 27;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(119, 87);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(102, 20);
            this.txtUser.TabIndex = 26;
            // 
            // txtAPS
            // 
            this.txtAPS.Location = new System.Drawing.Point(119, 54);
            this.txtAPS.Name = "txtAPS";
            this.txtAPS.Size = new System.Drawing.Size(102, 20);
            this.txtAPS.TabIndex = 25;
            // 
            // lblAPS
            // 
            this.lblAPS.AutoSize = true;
            this.lblAPS.Location = new System.Drawing.Point(45, 57);
            this.lblAPS.Name = "lblAPS";
            this.lblAPS.Size = new System.Drawing.Size(68, 13);
            this.lblAPS.TabIndex = 32;
            this.lblAPS.Text = "APS Server :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Password :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(79, 90);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 33;
            this.lblUser.Text = "User :";
            // 
            // frmConnect
            // 
            this.AcceptButton = this.btnList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 295);
            this.Controls.Add(this.txtEssServer);
            this.Controls.Add(this.lblEssbase);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblAppDB);
            this.Controls.Add(this.cboAppDB);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtAPS);
            this.Controls.Add(this.lblAPS);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEssServer;
        private System.Windows.Forms.Label lblEssbase;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblAppDB;
        private System.Windows.Forms.ComboBox cboAppDB;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtAPS;
        private System.Windows.Forms.Label lblAPS;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
    }
}