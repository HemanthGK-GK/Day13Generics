using System;

namespace GenericsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Neww<int> intt = new Neww<int>(25,46,16);
            intt.findMaximun();
            Neww<float> chr = new Neww<float>(7.5f,8.0f,2.6f);
            chr.findMaximun();
            Neww<string> str = new Neww<string>("not", "the", "problrm");
            str.findMaximun();
        }
    }
}
