using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    public partial class frmTuples : Form
    {
        public frmTuples()
        {
            InitializeComponent();
        }
        public frmTuples(String or, ListBox.ObjectCollection dims)
        {
            InitializeComponent();
            orientation = or;
            if (orientation == "Slicer") 
            {
                lblDimTuples.Text = or + "set :";
                this.Text = or + " Selection";
                lboDimensions.Items.AddRange(dims);
                selections = new ArrayList();
                this.btnAddTuple_Click(new Object(), new EventArgs());
            }
            else
            {
                lblDimTuples.Text = or + "sets :";
                this.Text = or + "set Selection";
                lboDimensions.Items.AddRange(dims);
                selections = new ArrayList();
            }
        }

        public ArrayList selections;
        public bool iQuit = true;
        private bool removingTuple = false;
        private String orientation = null;

        #region FORM EVENTS
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.iQuit = false;
            this.Close();
        }
        private void btnAddTuple_Click(object sender, EventArgs e)
        {
            if (orientation == "Slicer")
            {
                Tuple t = new Tuple(orientation, lboDimensions.Items.Count);
                for (int i = 0; i < lboDimensions.Items.Count; i++)
                {

                    t.selections[i].dimName = (String)lboDimensions.Items[i];
                    t.selections[i].selectionText = (String)lboDimensions.Items[i];
                    t.selections[i].isMemberSetFunction = false;
                }
                selections.Add(t);
                lboTuples.Items.Add(t);
                lboTuples.SetSelected(0, true);
            }
            else
            {
                Tuple t = new Tuple(orientation + " " + (lboTuples.Items.Count + 1), lboDimensions.Items.Count);
                for (int i = 0; i < lboDimensions.Items.Count; i++)
                {

                    t.selections[i].dimName = (String)lboDimensions.Items[i];
                    t.selections[i].selectionText = (String)lboDimensions.Items[i];
                    t.selections[i].isMemberSetFunction = false;
                }
                selections.Add(t);
                lboTuples.Items.Add(t);
                lboTuples.SetSelected(lboTuples.Items.Count - 1, true);
            }
            UpdateFormState();
        }
        private void btnRemoveTuple_Click(object sender, EventArgs e)
        {
            if (lboTuples.SelectedIndex >= 0)
            {
                if (lboTuples.Items.Count == 1)
                {
                    selections = new ArrayList();
                    lboTuples.Items.Clear();
                    txtSelection.Text = "";
                    UpdateFormState();
                    return;
                }
                removingTuple = true;
                int tempIndex = lboTuples.SelectedIndex;
                selections.Remove(lboTuples.SelectedItem);
                lboTuples.Items.Remove(lboTuples.SelectedItem);
                removingTuple = false;
                if (tempIndex == lboTuples.Items.Count)
                    lboTuples.SetSelected(tempIndex - 1, true);
                else
                    lboTuples.SetSelected(tempIndex, true);
                UpdateFormState();
            }
        }
        private void lboTuples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lboDimensions.SelectedIndex > 0))
                lboDimensions.SelectedIndex = 0;
            if (!removingTuple)
                lboDimensions_SelectedIndexChanged(sender, new EventArgs());
        }
        private void btnUpdateTuple_Click(object sender, EventArgs e)
        {
            ((Tuple)lboTuples.SelectedItem).selections[lboDimensions.SelectedIndex].selectionText = txtSelection.Text.Trim();
        }
        private void lboDimensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelection.Text = ((Tuple)lboTuples.SelectedItem).selections[lboDimensions.SelectedIndex].selectionText;
        }
        private void btnSelection_Click(object sender, EventArgs e)
        {
            frmMbrSelection mbrsel = new frmMbrSelection();
            mbrsel.ShowDialog();
            txtSelection.Text = mbrsel.selectionText;
            ((Tuple)lboTuples.SelectedItem).selections[lboDimensions.SelectedIndex].selectionText = mbrsel.selectionText;
            mbrsel = null;
        }
        #endregion

        #region UTILITY FUNCTIONS
        public void UpdateFormState()
        {
            if(orientation == "Slicer"){
                btnAddTuple.Enabled = false;
                btnRemoveTuple.Enabled = false;
                lboTuples.Enabled = false;
                lblDimensions.Enabled = true;
                lboDimensions.Enabled = true;
                lblSelection.Enabled = true;
                txtSelection.Enabled = true;
                btnNext.Enabled = true;
                btnSelection.Enabled = true;
                btnUpdateTuple.Enabled = true;
                return;
            }
            if (lboTuples.Items.Count > 0)
            {
                btnRemoveTuple.Enabled = true;
                lblDimensions.Enabled = true;
                lboDimensions.Enabled = true;
                lblSelection.Enabled = true;
                txtSelection.Enabled = true;
                btnNext.Enabled = true;
                btnSelection.Enabled = true;
                btnUpdateTuple.Enabled = true;
            }
            else
            {
                btnRemoveTuple.Enabled = false;
                lblDimensions.Enabled = false;
                lboDimensions.Enabled = false;
                lblSelection.Enabled = false;
                txtSelection.Enabled = false;
                btnNext.Enabled = false;
                btnSelection.Enabled = false;
                btnUpdateTuple.Enabled = false;
            }
        }
        #endregion

    }
}
