using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    public partial class frmPrefs : Form
    {
        public frmPrefs()
        {
            InitializeComponent();
        }

        #region FORM EVENTS
        private void frmPrefs_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.AutoSave)
            {
                chkAutoSave.Checked = true;
                txtAutoFile.Text = Properties.Settings.Default.AutoSaveLocation;
            }
            if (Properties.Settings.Default.NameAlias == "NAME")
                cboMbrDisplay.SelectedIndex = 0;
            else
                cboMbrDisplay.SelectedIndex = 1;
        }
        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSave.Checked)
            {
                btnBrowse.Enabled = true;
                txtAutoFile.Enabled = true;
            }
            else
            {
                btnBrowse.Enabled = false;
                txtAutoFile.Enabled = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            WriteSettings();
            this.Close();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            String filename = null;
            DialogResult dr = ofdAutoFile.ShowDialog();
            if (dr == DialogResult.OK)
                filename = ofdAutoFile.FileName;
            else
                return;
            txtAutoFile.Text = filename;
        }
        #endregion

        #region UTILITY FUNCTIONS
        private void WriteSettings()
        {
            Properties.Settings.Default["AutoSave"] = chkAutoSave.Checked;
            Properties.Settings.Default["AutoSaveLocation"] = txtAutoFile.Text.Trim();
            Properties.Settings.Default["NameAlias"] = cboMbrDisplay.SelectedItem;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region BASE CLASS OVERRIDES
        protected override void OnClosed(EventArgs e)
        {
            WriteSettings();
            base.OnClosed(e);
        }
        #endregion

    }
}
