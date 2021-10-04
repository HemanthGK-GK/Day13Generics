using System;

namespace UC4MaxGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] intArray = { 12, 56, 95, 74, 49 };
            Neww intt = new Neww();
            int i=intt.findMaximum<int>(intArray);
            Console.WriteLine(i);

            float[] floatArray = { 12.1f, 5.6f, 19.5f, 74.9f, 49.7f };
            Neww flo = new Neww();
            float f = flo.findMaximum<float>(floatArray);
            Console.WriteLine(f);

            string[] strArray = { "My", "First", "Project", "Git", "Apple" };
            Neww str = new Neww();
            string s = str.findMaximum<string>(strArray);
            Console.WriteLine(s);



        }
    }
}
