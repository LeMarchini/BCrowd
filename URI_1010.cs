using System;
using System.Globalization;

class URI_1010
{
    //BeeCrowd Problem #1010

    static void Main(string[] args)
    {
        string[] prod1 = Console.ReadLine().Split(' ');
        string[] prod2 = Console.ReadLine().Split(' ');

        int c1 = int.Parse(prod1[0]);
        int n1 = int.Parse(prod1[1]);
        double p1 = double.Parse(prod1[2], CultureInfo.InvariantCulture);

        int c2 = int.Parse(prod2[0]);
        int n2 = int.Parse(prod2[1]);
        double p2 = double.Parse(prod2[2], CultureInfo.InvariantCulture);

        double total = (n1 * p1) + (n2 * p2);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }

}