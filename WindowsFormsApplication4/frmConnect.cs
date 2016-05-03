using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.essbase.api.@base;
using com.essbase.api.datasource;
using com.essbase.api.dataquery;
using com.essbase.api.metadata;
using com.essbase.api.domain;
using com.essbase.api.session;
using System.Collections;

namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    public partial class frmConnect : Form
    {
        //TODO: Make these two passed in properties from frmMain
        private const String DOMAIN = "essbase";
        private const String JAPI_VERSION = "11.1.2.4";
        public String essUser = null;
        public String essPW = null;
        public String essServer = null;
        public String apsProviderURL = null;
        public String essApp = null;
        public String essDB = null;

        public IEssCubeView cv = null;
        public IEssbase ess = null;
        public IEssDomain dom = null;
        public IEssOlapServer svr = null;
        public bool connected = false;

        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                essApp = ((String)((String[])(cboAppDB.SelectedItem.ToString().Split('|')))[0]).Trim();
                essDB = ((String)((String[])(cboAppDB.SelectedItem.ToString().Split('|')))[1]).Trim();
                if (cv != null)
                    cv.close();
                cv = svr.getApplication(essApp).getCube(essDB).openCubeView("JDH_CubeView");
                connected = true;
                this.Dispose();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error connecting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                essUser = txtUser.Text.Trim();
                essPW = txtPW.Text.Trim();
                apsProviderURL = txtAPS.Text.Trim();
                if (!(apsProviderURL.Contains("http://") || apsProviderURL.Contains("https://")))
                    apsProviderURL = "http://" + txtAPS.Text.Trim();
                if(!apsProviderURL.Substring(apsProviderURL.IndexOf("//")).Contains(":"))
                    apsProviderURL += ":19000";
                if(!apsProviderURL.Contains("/aps/JAPI"))
                    apsProviderURL += "/aps/JAPI";
                essServer = txtEssServer.Text.Trim();
                ess = IEssbase.Home.create(JAPI_VERSION);
                svr = ess.signOn(essUser, essPW, false, null, apsProviderURL, essServer);
                PopulateAppDBList();
                lblAppDB.Enabled = true;
                cboAppDB.Enabled = true;
                btnConnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Unable to connect: {0}\nURL tried: {1}", ex.Message, apsProviderURL), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAppDBList()
        {
            ArrayList appCubeList = new ArrayList();
            IEssIterator it = svr.getApplications();
            for (int i = 0; i < it.getCount(); i++)
            {
                IEssIterator it2 = ((IEssOlapApplication)it.getAt(i)).getCubes();
                for (int j = 0; j < it2.getCount(); j++)
                {
                    appCubeList.Add(((IEssOlapApplication)it.getAt(i)).getName() + " | " + ((IEssCube)it2.getAt(j)).getName());
                }
            }
            appCubeList.Sort();
            cboAppDB.DataSource = appCubeList;
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            if (essServer != null)
                txtEssServer.Text = essServer;
            if (essUser != null)
                txtUser.Text = essUser;
            if (essPW != null)
                txtPW.Text = essPW;
            if (apsProviderURL != null)
                txtAPS.Text = apsProviderURL;
            //TODO: load app/db selection <-- revisited later... why would I need this?
        }
    }
}
