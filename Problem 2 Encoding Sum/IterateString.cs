using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IterateString
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        byte condition;
        int current = 0;
        int result = 0; 

        foreach (var character in text)
        {

            if (Char.IsDigit(character))  // Number
            {
                condition = 1;
                current = (int)Char.GetNumericValue(character);

            }
            else if (Char.IsLetter(character)) // Alphabet Character
            {
                condition = 2;
                current = Char.ToUpper(character) - 65;
            }
            else if (character == '@') // @ = end
            {
                condition = 3;
                break;
            }
            else // Other Values
            {
                condition = 4;
            }

            switch (condition)
            {
                case 1: result *= current;
                    break;
                case 2: result += current;
                    break;
                case 3: break;
                case 4: result %= m;
                    break;
            }
        }

        Console.WriteLine(result);
    }
}