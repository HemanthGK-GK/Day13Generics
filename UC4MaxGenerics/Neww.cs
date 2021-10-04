using System;
using System.Collections.Generic;
using System.Text;

namespace UC4MaxGenerics
{
    class Neww
    {
        public T[] Sort<T>(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T findMaximum<T>(params T[] values ) where T : IComparable<T>
        {
            var Svalues = Sort(values);
            return Svalues[Svalues.Length - 1];
        }
    }
}
