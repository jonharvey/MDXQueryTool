using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace com.ecapitaladvisors.hyperion.MDXQueryTool
{
    class Tuple
    {
        public TupleSelection[] selections; // Holds TupleDimSelections
        private String tupleName = null;

        public Tuple(String name, int dimCount)
        {
            selections = new TupleSelection[dimCount];
            for (int i = 0; i < dimCount; i++)
                selections[i] = new TupleSelection();
            tupleName = name;
        }
        public override String ToString()
        {
 	         return tupleName;
        }

    }
    class TupleSelection
    {
        public String selectionText = null;
        public String dimName = null;
        public bool isMemberSetFunction = false;

        public TupleSelection(){}
    }
}
