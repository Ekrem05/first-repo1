using System;
public class Program
{
    public static void Main()
    {
        //Напишете програма, която въвежда средния успех на учениците в една група и извежда ученик с най-високия успех.
        Console.WriteLine("Колко са броя на учениците ");
        int n = int.Parse(Console.ReadLine());
        double max = 0;
        for (int i = 0; i <= n - 1; i++)
        {
            Console.WriteLine("Въведете успеха на ученика ");
            double srUspeh = double.Parse(Console.ReadLine());
            if (srUspeh > max)
            {
                max = srUspeh;
            }
        }
        Console.WriteLine("Максималния успех е {0:f2} ", max);
    }
}
