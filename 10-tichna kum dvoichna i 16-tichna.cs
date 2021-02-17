using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int chislo = 1234;
            string dv = Convert.ToString(chislo, 2);
            string shes = Convert.ToString(chislo, 16);
            Console.WriteLine("desetichno: {0}", dv);
            Console.WriteLine("6-tichno: {0}", shes);
        }
    }
}
