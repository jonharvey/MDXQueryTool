using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    public partial class frmQueryHistory : Form
    {

        //Member variables/properties
        private bool boolLoadQry = false;
        private String strQueryText = null;
        private DataTable dtHistory;
        private MDXLexer mdxlexer;
        private int lastCaretPos = 0;
        private int maxLineNumberCharLength = 6;

        #region Property accessors
        public bool loadQuery {
            get{return this.boolLoadQry;}
        }
        public String queryText
        {
            get { return this.strQueryText; }
        }
        #endregion

        #region Constructors
        public frmQueryHistory() 
        {
            InitializeComponent();
        }     
        public frmQueryHistory(DataTable dt)
        {
            InitializeComponent();
            this.dtHistory = dt;
        }
        #endregion

        #region Form events
        private void frmQueryHistory_Load(object sender, EventArgs e)
        {
            FormatCodeBox();
            binddsQueryHist.DataSource = this.dtHistory;
            scintQry.DataBindings.Add("Text", binddsQueryHist, "QueryText");
            lblUser.DataBindings.Add("Text", binddsQueryHist, "ExecutedBy");
            lblExecDate.DataBindings.Add("Text", binddsQueryHist, "Timestamp");
            lblExecTime.DataBindings.Add("Text", binddsQueryHist, "ElapsedTime");
            binddsQueryHist.MoveLast();
            scintQry.ReadOnly = true;
            bindnavQuerySet.Focus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmQueryHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                scintQry.ReadOnly = false;
                binddsQueryHist.MoveNext();
                scintQry.SelectionStart = 0;
                scintQry.SelectionEnd = 0;
                scintQry.ReadOnly = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                scintQry.ReadOnly = false;
                binddsQueryHist.MovePrevious();
                scintQry.SelectionStart = 0;
                scintQry.SelectionEnd = 0;
                scintQry.ReadOnly = true;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.boolLoadQry = true;
            this.strQueryText = scintQry.Text;
            this.Close();
        }
        #endregion

        #region ScintillaNET CODE FORMATTING FUNCTIONS
        private void FormatCodeBox()
        {
            this.mdxlexer = new MDXLexer("Dimension set member index END property from SELECT NON EMPTY COLUMNS FROM WHERE ROWS AXIS ON PAGES CHAPTERS SECTIONS PROPERTIES AFTER BEFORE ALL or AND NOT IN first AVERAGE FOR Level CREATE DELETE WHEN THEN Abs Aggregate Ancestor Attribute Avg BottomCount BottomPercent BottomSum CASE Children ClosingPeriod CoalesceEmpty Concat Contains Count Cousin CrossJoin CurrentMember CurrentTuple DateDiff DatePart DateRoll DateToMember DefaultMember Descendants Distinct DrilldownByLayer DrilldownMember DrillupByLayer DrillupMember Except Exp Extract Factorial FILTER FirstChild FirstSibling FormatDate GetFirstDate GetLastDate Generate Generations Generations Head Hierarchize IIF InStr Int Intersect IS IsAccType IsAncestor IsChild IsEmpty IsGeneration IsLeaf IsLevel IsSibling IsUda IsValid Item Item Lag LastChild LastPeriods LastSibling Lead Left Len Leaves Levels Levels Ln Log Log10 Lower LTrim Max Median MemberRange Members Min Mod NextMember NonEmptyCount NTile Ordinal ParallelPeriod Parent Percentile PeriodsToDate Power PrevMember Rank Remainder Right Round RTrim Siblings Stddev Stddevp StrToMbr StrToNum Subset Substring Sum Tail Todate TodateEx Today TopCount TopPercent TopSum Truncate TupleRange Uda Union Upper WithAttr Generation xTD IS ANY");
            scintQry.Margins[0].Width = 16;
            scintQry.StyleResetDefault();
            scintQry.Styles[Style.Default].Font = "Consolas";
            scintQry.Styles[Style.Default].Size = 10;
            scintQry.StyleClearAll();

            scintQry.Styles[MDXLexer.StyleDefault].ForeColor = Color.Black;
            scintQry.Styles[MDXLexer.StyleKeyword].ForeColor = Color.Blue;
            scintQry.Styles[MDXLexer.StyleIdentifier].ForeColor = Color.Teal;
            scintQry.Styles[MDXLexer.StyleNumber].ForeColor = Color.Purple;
            scintQry.Styles[MDXLexer.StyleString].ForeColor = Color.Red;

            scintQry.Lexer = Lexer.Container;
        }
        private void scintQry_StyleNeeded(object sender, StyleNeededEventArgs e)
        {
            var startPos = scintQry.GetEndStyled();
            var endPos = e.Position;

            mdxlexer.Style(scintQry, startPos, endPos);
        }
        private void scintQry_UpdateUI(object sender, UpdateUIEventArgs e)
        {

        }
        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '<':
                case '>':
                    return true;
            }

            return false;
        }
        private void scintQry_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
