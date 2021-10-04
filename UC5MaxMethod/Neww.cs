using System;
using System.Collections.Generic;
using System.Text;

namespace UC5MaxMethod
{
    class Neww
    {
        public T[] Sort<T>(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T printMax<T>(params T[] values) where T : IComparable<T>
        {
            
            var Svalues = Sort(values);
            return Svalues[Svalues.Length - 1];
            
        }
        public T testMax<T>(T[] values) where T : IComparable<T>
        {
            T max = printMax(values);
            Console.WriteLine("Maximum value is " + max);
            return max;
           
        }


    }
}
