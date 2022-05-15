using System;
using System.Globalization;

class URI_1014
{
    //BeeCrowd Problem #1014

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double cons = x / y;

        Console.WriteLine(cons.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
    }

}