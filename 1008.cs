using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int hr = int.Parse(Console.ReadLine());
        double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double sal = hr * val;


        Console.WriteLine("NUMBER = " + num);
        Console.WriteLine("SALARY = U$ " + sal.ToString("F2", CultureInfo.InvariantCulture));

    }

}