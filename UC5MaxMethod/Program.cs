using System;

namespace UC5MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 97, 85, 46, 75, 35 };
            Neww intt = new Neww();
            intt.printMax<int>(intArray);
            intt.testMax(intArray);

            string[] strArray = { "My", "First", "Project", "Git", "Apple" };
            Neww str = new Neww();
            string s = str.printMax<string>(strArray);
            intt.testMax(strArray);

        }
    }
}
