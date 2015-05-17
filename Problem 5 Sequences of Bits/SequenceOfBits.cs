    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceOfBits
{
    static void Main(string[] args)
    {

        byte n = byte.Parse(Console.ReadLine());
        uint number;
        string binary;
        string concatinadted = null;

        int zeroesCounter = 0;
        int onesCounter = 0;
        int zeroesTemp = 0;
        int onesTemp = 0;

        for (int i = 0; i < n; i++)
        {
            binary = "000000000000000000000000000000"; // Add 30 zeroes at the start of the string (Couldn't come up with a better way to do it at the time)
            number = uint.Parse(Console.ReadLine());
            binary += Convert.ToString(number, 2);

            if (binary.Length > 30)
            {
                binary = binary.Remove(0, binary.Length - 30); // Leave the string with the last 30 bits of the number.
            }

            concatinadted += binary;
        }

        foreach (var digit in concatinadted)  
        {
            if (digit == '0') // Count the longest streak of zeroes & reset the current streak of 1s
            {
                onesTemp = 0;
                zeroesTemp++;

                if (zeroesTemp > zeroesCounter)
                {
                    zeroesCounter = zeroesTemp;
                }
            }

            if (digit == '1') // Count the longest streak of 1s & reset the current streak of zeroes
            {
                zeroesTemp = 0;
                onesTemp++;

                if (onesTemp > onesCounter)
                {
                    onesCounter = onesTemp;
                }
            }
        }

        Console.WriteLine(onesCounter);
        Console.WriteLine(zeroesCounter);
    }
}
