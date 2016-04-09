using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using Microsoft.Office.Interop;
using Microsoft.VisualBasic;
using EncryptionLibrary;

using com.essbase.api.@base;
using com.essbase.api.datasource;
using com.essbase.api.dataquery;
using com.essbase.api.metadata;
using com.essbase.api.domain;
using com.essbase.api.session;

namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public enum ConnectionState { Connected, Disconnected };
        public ConnectionState frmState = ConnectionState.Disconnected;
        public IEssCubeView cv = null;
        public IEssbase ess = null;
        public IEssOlapServer svr = null;
        public IEssOpMdxQuery qry = null;
        public String m_qry = null;
        public int rowHeaderCols = 0;
        public int colHeaderRows = 0;
        public String essUser = null;
        public String essPW = null;
        public String essApp = null;
        public String essDB = null;
        public String essServer = null;
        public String apsProviderURL = null;
        private const String DOMAIN = "essbase";
        //TODO: make this so it can handle flexible versions
        //      maybe parse the version from the APS JAPI landing page?
        private const String JAPI_VERSION = "11.1.2.4";
        private const String key = "*3ssB@5E";
        private const String IV = "3ssBA5E_ru1e5!!!";
        public System.Timers.Timer connectionTimer = null;
        public System.Diagnostics.Stopwatch elapsedTime = null;

        #region FORM EVENTS
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoSave)
                LoadConfig(Properties.Settings.Default.AutoSaveLocation);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (frmState == ConnectionState.Disconnected)
            {
                try
                {
                    if (Connect())
                    {
                        frmState = ConnectionState.Connected;
                        UpdateFormState();
                        txtQuery.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting: " + ex.Message, "Connection status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Disconnect();
                    frmState = ConnectionState.Disconnected;
                    UpdateFormState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting: " + ex.Message, "Connection status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                //Update vars with input text
                m_qry = txtQuery.Text;

                //Create the query object
                qry = cv.createIEssOpMdxQuery();

                //TODO: Any other query properties that should be added here?
                if(Properties.Settings.Default.NameAlias == "NAME")
                    qry.setQuery(false, m_qry, false, IEssOpMdxQuery.EEssMemberIdentifierType.NAME);
                else
                    qry.setQuery(false, m_qry, false, IEssOpMdxQuery.EEssMemberIdentifierType.ALIAS);

                //Execute the query
                cv.performOperation(qry);

                //Retrieve and parse the multi-dimensional data set
                IEssMdDataSet ds = cv.getMdDataSet();
                DataTable dt = ParseMdDataSet(ds);

                //Bind the parsed data (DataTable obj) to the grid
                dgvResults.DataSource = dt;

                //Set the grid style
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.Black;
                style.ForeColor = Color.White;
                style.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                for (int i = 0; i < colHeaderRows; i++)
                    dgvResults.Rows[i].DefaultCellStyle = style;
                for (int i = 0; i < rowHeaderCols; i++)
                    dgvResults.Columns[i].DefaultCellStyle = style;
                dgvResults.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            //TODO: Why is none of this shit in try/catch??? c'mon rook...
            String filename = null;
            DialogResult dr = sfdExport.ShowDialog();
            if (dr == DialogResult.OK)
                filename = sfdExport.FileName;
            else
                return;

            switch (sfdExport.FilterIndex)
            {
                case 1:
                    Microsoft.Office.Interop.Excel.Application xlApp;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Name = "Data";

                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dgvResults.RowCount - 1; i++)
                    {
                        for (j = 0; j <= dgvResults.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dgvResults[j, i];
                            xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                        }
                    }
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                    xlWorkSheet.Name = "Query";
                    xlWorkSheet.Cells[1, 1] = txtQuery.Text;
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
                    xlWorkSheet.Delete();

                    xlWorkBook.SaveAs(filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    MessageBox.Show("Excel file created: " + filename);
                    break;

                case 2:
                    WriteToFile(',', filename);
                    break;
                case 3:
                    WriteToFile('|', filename);
                    break;
            }
        }
        #endregion

        #region MENU EVENTS
        private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = null;
            DialogResult dr = sfdConfig.ShowDialog();
            if (dr == DialogResult.OK)
                filename = sfdConfig.FileName;
            else
                return;
            WriteConfig(filename);
        }
        private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = null;
            DialogResult dr = ofdConfig.ShowDialog();
            if (dr == DialogResult.OK)
                filename = ofdConfig.FileName;
            else
                return;
            LoadConfig(filename);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
            about = null;
        }
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrefs pref = new frmPrefs();
            pref.ShowDialog();
        }
        private void queryBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueryLayout bld = new frmQueryLayout(svr, essApp, essDB);
            bld.ShowDialog();
            if (bld.completed)
            {
                m_qry = bld.builtQuery;
                txtQuery.Text = m_qry;
            }
            bld = null;
        }
        #endregion

        #region UTILITY FUNCTIONS
        public void Disconnect()
        {
            if (cv != null)
                cv.close();
            if (svr != null && svr.isConnected())
                svr.disconnect();
            if (ess != null && ess.isSignedOn())
                ess.signOff();
        }
        public bool Connect()
        {
            frmConnect frm = new frmConnect();
            if (essServer != null)
                frm.essServer = this.essServer;
            if (essUser != null)
                frm.essUser = this.essUser;
            if (essPW != null)
                frm.essPW = this.essPW;
            if (essApp != null)
                frm.essApp = this.essApp;
            if (essDB != null)
                frm.essDB = this.essDB;
            if (apsProviderURL != null)
                frm.apsProviderURL = this.apsProviderURL.Substring(apsProviderURL.IndexOf("//") + 2, apsProviderURL.LastIndexOf(":") - apsProviderURL.IndexOf("//") - 2);
            frm.ShowDialog();
            if (frm.connected)
            {
                this.cv = frm.cv;
                this.ess = frm.ess;
                this.svr = frm.svr;
                this.essServer = frm.essServer;
                this.essUser = frm.essUser;
                this.essPW = frm.essPW;
                this.apsProviderURL = frm.apsProviderURL;
                this.essApp = frm.essApp;
                this.essDB = frm.essDB;
                frm = null;
                return true;
            }
            return false;
        }
        public void UpdateFormState()
        {
            if (frmState == ConnectionState.Connected)
            {
                btnConnect.Text = "&Disconnect";
                btnExecute.Enabled = true;
                btnExport.Enabled = true;
                txtQuery.Enabled = true;
                dgvResults.Enabled = true;
                saveConfigToolStripMenuItem.Enabled = true;
                loadConfigToolStripMenuItem.Enabled = false;
                queryBuilderToolStripMenuItem.Enabled = true;
                tsslStatusOut.ForeColor = Color.Green;
                this.connectionTimer = new System.Timers.Timer(1000);
                this.connectionTimer.Elapsed += new ElapsedEventHandler(this.TickTock);
                this.connectionTimer.Enabled = true;
                this.connectionTimer.Start();
                this.elapsedTime = new System.Diagnostics.Stopwatch();
                this.elapsedTime.Start();
            }
            else
            {
                btnConnect.Text = "&Connect";
                btnExecute.Enabled = false;
                btnExport.Enabled = false;
                txtQuery.Enabled = false;
                dgvResults.DataSource = null;
                dgvResults.Enabled = false;
                saveConfigToolStripMenuItem.Enabled = false;
                loadConfigToolStripMenuItem.Enabled = true;
                queryBuilderToolStripMenuItem.Enabled = false;
                tsslStatusOut.Text = "Disconnected";
                tsslStatusOut.ForeColor = Color.Red;
                this.connectionTimer.Enabled = false;
                this.connectionTimer.Stop();
                this.elapsedTime.Stop();
                this.elapsedTime.Reset();
            }
        }
        private DataTable ParseMdDataSet(IEssMdDataSet ds)
        {
            DataTable dt = new DataTable();

            IEssMdAxis[] axis = ds.getAllAxes();
            IEssMdMember[] mbrs = null;
            rowHeaderCols = 0;
            colHeaderRows = 0;
            int rowNum = 0;
            int colNum = 0;

            // Initialize the table shape (number of row/col headers)
            for (int i = 0; i < axis[1].getTupleCount(); i++)
            {
                dt.Columns.Add(); // Add a column for each column in results
            }
            for (int x = 2; x < axis.GetLength(0); x++)
            {
                rowHeaderCols += axis[x].getAllTupleMembers(0).Count();
                foreach (IEssMdMember tmp in axis[x].getAllTupleMembers(0))
                    dt.Columns.Add(); // Add a column for each row header or tuple member in results
            }
            for (int j = 0; j < axis[1].getDimensionCount(); j++)
            {
                colHeaderRows++;
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr); // Add a row for each dimension in the header
            }

            // Populate column headers
            for (colNum = 0; colNum < axis[1].getTupleCount(); colNum++)
            {
                mbrs = axis[1].getAllTupleMembers(colNum);
                for (rowNum = 0; rowNum < mbrs.GetLength(0); rowNum++)
                {
                    dt.Rows[rowNum][colNum + rowHeaderCols] = mbrs[rowNum].getName();
                }
            }

            // Populate the rows
            int cellIndex = 0;
            int numDataCols = dt.Columns.Count - rowHeaderCols;
            DataRow newRow = null;

            // For each cell in the DataSet (left to right, top to bottom)
            while (cellIndex < ds.getCellCount())
            {
                // If it's the first cell of the row, create a new row and build the row header cells
                if (cellIndex % numDataCols == 0)
                {
                    newRow = dt.NewRow();
                    int rowHeaderCount = 0;
                    for (int x = 2; x < axis.GetLength(0); x++)
                    {
                        foreach (IEssMdMember tmp in axis[x].getAllTupleMembers(cellIndex / numDataCols))
                        {
                            newRow[rowHeaderCount] = tmp.getName();
                            rowHeaderCount++;
                        }
                    }
                }
                if (ds.isMissingCell(cellIndex))
                    //TODO: Add a preference for #Missing/#NoAccess label
                    newRow[cellIndex % numDataCols + rowHeaderCols] = "#Missing";
                else if (ds.isNoAccessCell(cellIndex))
                    //TODO: Add a preference for #Missing/#NoAccess label
                    newRow[cellIndex % numDataCols + rowHeaderCols] = "#NoAccess";
                else
                    //TODO: Add a preference for number format
                    //TODO: Add a preference for number scale
                    newRow[cellIndex % numDataCols + rowHeaderCols] = ds.getCellValue(cellIndex);
                cellIndex++;
                if (cellIndex % numDataCols == 0)
                    dt.Rows.Add(newRow);
            }
            return dt;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void WriteToFile(char delimiter, String filename)
        {
            TextWriter outfile = new StreamWriter(filename);
            int x = 0;
            int y = 0;

            for (x = 0; x <= dgvResults.RowCount - 1; x++)
            {
                for (y = 0; y <= dgvResults.ColumnCount - 1; y++)
                {
                    DataGridViewCell cell = dgvResults[y, x];
                    if (y == dgvResults.ColumnCount - 1)
                        outfile.WriteLine(cell.Value.ToString());
                    else
                        outfile.Write(cell.Value.ToString() + delimiter);
                }
                outfile.Flush();
            }
            outfile.Close();
            MessageBox.Show("Text file created: " + filename);
            return;
        }
        private void WriteConfig(String filename)
        {
            TextWriter outfile = null;
            EncryptionWrapper enc = null;
            try
            {
                enc = new EncryptionWrapper();
                enc.InitializeCipher(key, IV);
                outfile = new StreamWriter(filename);
                outfile.WriteLine("essServer|{0}", essServer);
                outfile.WriteLine("apsServer|{0}", this.apsProviderURL.Substring(apsProviderURL.IndexOf("//") + 2, apsProviderURL.LastIndexOf(":") - apsProviderURL.IndexOf("//") - 2));
                outfile.WriteLine("essUser|{0}", essUser);
                outfile.WriteLine("essPW|{0}", System.Convert.ToBase64String(enc.Encrypt(System.Text.Encoding.ASCII.GetBytes(essPW))));
                outfile.WriteLine("essApp|{0}", essApp);
                outfile.WriteLine("essDB|{0}", essDB);
                outfile.WriteLine("query|{0}", txtQuery.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving config file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (outfile != null)
                {
                    outfile.Flush();
                    outfile.Close();
                }
                enc = null;
            }
            return;
        }
        private void LoadConfig(String filename)
        {
            StreamReader cfg = null;
            EncryptionWrapper dec = null;
            try
            {
                dec = new EncryptionWrapper();
                dec.InitializeCipher(key, IV);
                cfg = new StreamReader(filename);
                String line = null;
                String[] values = null;
                while ((line = cfg.ReadLine()) != null)
                {
                    values = line.Split('|');
                    switch (values[0])
                    {
                        case "essServer":
                            this.essServer = values[1];
                            break;
                        case "apsServer":
                            this.apsProviderURL = "http://" + values[1] + ":13080/aps/JAPI";
                            break;
                        case "essUser":
                            this.essUser = values[1];
                            break;
                        case "essPW":
                            this.essPW = System.Text.Encoding.ASCII.GetString(dec.Decrypt(System.Convert.FromBase64String(values[1])));
                            break;
                        case "essApp":
                            this.essApp = values[1];
                            break;
                        case "essDB":
                            this.essDB = values[1];
                            break;
                        case "query":
                            this.m_qry = values[1] + cfg.ReadToEnd();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading config file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                if (cfg != null)
                    cfg.Close();
                dec = null;
            }
            try
            {
                if (ess == null || !ess.isSignedOn())
                    ess = IEssbase.Home.create(JAPI_VERSION);
                if (svr == null || !svr.isConnected())
                    svr = ess.signOn(essUser, essPW, false, null, apsProviderURL, essServer);
                if (cv != null)
                    cv.close();
                cv = svr.getApplication(essApp).getCube(essDB).openCubeView("JDH_CubeView");
                frmState = ConnectionState.Connected;
                txtQuery.Text = m_qry;
                UpdateFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting with configuration provided: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
        private void TickTock(object sender, ElapsedEventArgs e)
        {
            tsslStatusOut.Text = String.Format("Connected | {0}.{1} | {2}", essApp, essDB, elapsedTime.Elapsed.ToString("hh\\:mm\\:ss"));
        }
        #endregion

        #region BASE CLASS OVERRIDES
        protected override void OnClosed(EventArgs e)
        {
            if (frmState == ConnectionState.Connected)
            {
                this.connectionTimer.Stop();
                this.elapsedTime.Stop();
                Disconnect();
            }
            base.OnClosed(e);
        }
        #endregion

    }
}
