using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalcMoney
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double totalS = n * s;
        double totalP = totalS / 400;

        double price = totalP * p;

        Console.WriteLine("{0:F3}", price);
    }
}