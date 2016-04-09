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
    public partial class frmQueryLayout : Form
    {
        public frmQueryLayout()
        {
            InitializeComponent();
            AddHandlers();
        }
        public frmQueryLayout(IEssOlapServer server, String app, String DB) 
        {
            svr = server;
            essApp = app;
            essDB = DB;
            InitializeComponent();
            AddHandlers();
        }

        private IEssOlapServer svr = null;
        private String essApp = null;
        private String essDB = null;
        public bool completed = false;
        public String builtQuery = null;
        private ArrayList columns = null;
        private ArrayList rows = null;
        private ArrayList slicer = null;

        #region FORM EVENTS
        private void frmQueryBuilder_Load(object sender, EventArgs e)
        {
            columns = new ArrayList();
            rows = new ArrayList();
            slicer = new ArrayList();
            IEssIterator it = svr.getApplication(essApp).getCube(essDB).getDimensions();
            for (int i = 0; i < it.getCount(); i++) 
            {
                if (((IEssDimension)it.getAt(i)).getAttributeDimensionDataType() == IEssDimension.EEssAttributeDataType.NONE && ((IEssDimension)it.getAt(i)).getName() != "Attribute Calculations")
                    lboDimensions.Items.Add(((IEssDimension)it.getAt(i)).getName());
            }
            it = null;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            errLayout.Clear();
            if (lboRows.Items.Count == 0)
            {
                errLayout.SetError(lblRows, "At least one dimension has to be in the rows for a valid query.");
                return;
            }
            if (lboColumns.Items.Count == 0)
            {
                errLayout.SetError(lblColumns, "At least one dimension has to be in the columns for a valid query.");
                return;
            }
            else
            {
                this.Visible = false;
                frmTuples frmDimTuples = new frmTuples("Column", lboColumns.Items);
                frmDimTuples.ShowDialog();
                if (frmDimTuples.iQuit)
                {
                    this.Close();
                    return;
                }
                columns = frmDimTuples.selections;
                frmDimTuples = new frmTuples("Row", lboRows.Items);
                frmDimTuples.ShowDialog();
                if (frmDimTuples.iQuit)
                {
                    this.Close();
                    return;
                }
                rows = frmDimTuples.selections;
                if (lboSlicer.Items.Count > 0)
                {
                    frmDimTuples = new frmTuples("Slicer", lboSlicer.Items);
                    frmDimTuples.ShowDialog();
                    if (frmDimTuples.iQuit)
                    {
                        this.Close();
                        return;
                    }
                    slicer = frmDimTuples.selections;
                }
                this.GenerateMDX();
            }
        }
        #endregion

        #region UTILITY FUNCTIONS
        public void lbo_MouseDown(Object sender, MouseEventArgs e)
        {
            try
            {
                if (((ListBox)sender).Items.Count == 0)
                    return;
                String temp = ((ListBox)sender).Items[((ListBox)sender).IndexFromPoint(e.X, e.Y)].ToString();
                DragDropEffects dde = DoDragDrop(temp, DragDropEffects.All);
                if (dde == DragDropEffects.All)
                    ((ListBox)sender).Items.RemoveAt(((ListBox)sender).IndexFromPoint(e.X, e.Y));
            }
            catch (ArgumentOutOfRangeException argOORex) 
            { 
                // do nothing
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void lbo_DragDrop(Object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                String temp = (String)(e.Data.GetData(DataFormats.StringFormat));
                ((ListBox)sender).Items.Add(temp);
            }
        }
        public void lbo_DragOver(Object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        public void AddHandlers()
        {
            this.lboSlicer.DragDrop += new DragEventHandler(this.lbo_DragDrop);
            this.lboSlicer.MouseDown += new MouseEventHandler(this.lbo_MouseDown);
            this.lboSlicer.DragOver += new DragEventHandler(this.lbo_DragOver);
            this.lboRows.DragDrop += new DragEventHandler(this.lbo_DragDrop);
            this.lboRows.MouseDown += new MouseEventHandler(this.lbo_MouseDown);
            this.lboRows.DragOver += new DragEventHandler(this.lbo_DragOver);
            this.lboColumns.DragDrop += new DragEventHandler(this.lbo_DragDrop);
            this.lboColumns.MouseDown += new MouseEventHandler(this.lbo_MouseDown);
            this.lboColumns.DragOver += new DragEventHandler(this.lbo_DragOver);
            this.lboDimensions.DragDrop += new DragEventHandler(this.lbo_DragDrop);
            this.lboDimensions.MouseDown += new MouseEventHandler(this.lbo_MouseDown);
            this.lboDimensions.DragOver += new DragEventHandler(this.lbo_DragOver);
        }
        public void GenerateMDX() 
        {
            //append to query string
            this.builtQuery = String.Format("SELECT\r\n    {0} ON COLUMNS,\r\n    {1} ON ROWS\r\n", BuildAxisText(columns), BuildAxisText(rows));

            // FROM definition
            this.builtQuery += String.Format("FROM [{0}].[{1}]", essApp, essDB);

            // Build slicer definition
            if (slicer.Count > 0)
            {
                this.builtQuery += "\r\nWHERE (";
                foreach (TupleSelection selection in ((Tuple)(slicer[0])).selections) 
                {
                    this.builtQuery += String.Format("[{0}],", selection.selectionText);
                }
                this.builtQuery = this.builtQuery.Remove(this.builtQuery.Length - 1, 1);
                this.builtQuery += ")";
            }

            this.completed = true;
            return;
        }
        public String BuildAxisText(ArrayList axisTuples)
        {
            String axisText = null;
            String tupleText = null;

            for (int j = 0; j < axisTuples.Count; j++)
            {
                Tuple t = (Tuple)axisTuples[j];
                tupleText = "";
                for (int i = 0; i < t.selections.Length; i++)
                {
                    TupleSelection ts = t.selections[i];
                    if (i == 0)
                        tupleText = String.Format("{{{0}}}", ts.selectionText);
                    else
                        tupleText = String.Format("{{CrossJoin({{{0}}},{1})}}", ts.selectionText, tupleText);
                }
                if (j > 0)
                    axisText = String.Format("{0},{1}", axisText, tupleText);
                else
                    axisText = tupleText;
            }
            if (axisTuples.Count > 1)
                axisText = String.Format("{{{0}}}", axisText);

            return axisText;
        }
        #endregion

    }
}
