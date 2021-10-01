using System;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Neww ob = new Neww();
            ob.findMaximum<int>(25, 63, 14);
            ob.findMaximum<float>(4.2f,5.6f,69.4f);
            ob.findMaximum<char>('a', 'b', 'c');
            
            
        }
    }
}
