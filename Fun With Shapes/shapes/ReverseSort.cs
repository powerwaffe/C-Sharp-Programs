using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class ReverseSort : IComparer
    {
        public int Compare(object x, object y)
        {
            // reverse the arguments
            return Comparer.Default.Compare(y, x);
        }
    }
}
