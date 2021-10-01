using System;
using System.Collections.Generic;
using System.Text;

namespace UC3MaxString
{
    class Neww
    {
        public void findMaximum(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("The Greatest Number is : " + first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("The Greatest Number is : " + second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine("The Greatest Number is : " + third);
            }
            else
                Console.WriteLine("All are equal");

        }
    }
}
