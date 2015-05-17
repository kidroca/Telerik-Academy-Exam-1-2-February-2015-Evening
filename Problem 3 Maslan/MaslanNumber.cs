using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class MaslanNumber
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        uint sum = 0;
        BigInteger prod = 1;
        byte trans = 0;
        byte currentDigit;

        while (str.Length > 1)
        {

            str = str.Remove(str.Length - 1);

            for (int i = 1; i < str.Length; i += 2)
            {
                currentDigit = (byte)Char.GetNumericValue(str[i]);
                if (currentDigit == 0) { continue; }
                sum += currentDigit;
            }
            if (sum == 0) { sum = 1; }
            prod *= sum;
            sum = 0;
            if (str.Length < 3)
            {
                trans++;
                str = Convert.ToString(prod);
                prod = 1;

                if (trans == 10)
                {
                    Console.WriteLine(str);
                    break;
                }
            }
        }

        if (trans != 10)
        {
            Console.WriteLine(trans);
            Console.WriteLine(str);
        }
    }
}