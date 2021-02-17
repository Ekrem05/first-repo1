using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {   
            string bin = "1100101";
            int dec = Convert.ToInt32(bin, 2);
            string xec = Convert.ToString(dec, 16);
            Console.WriteLine("dvoichno {0}", bin);
            Console.WriteLine("desetichno {0}", dec);
            Console.WriteLine("16-tichno {0}", xec);

        }
    }
} 
