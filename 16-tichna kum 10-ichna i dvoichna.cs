using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string xec="abc";
            int dec = Convert.ToInt32(xec, 16);
            string bin = Convert.ToString(dec, 2);
            Console.WriteLine("desetichna" + dec);
            Console.WriteLine("dvoichna" + bin);
        }
    }
}
