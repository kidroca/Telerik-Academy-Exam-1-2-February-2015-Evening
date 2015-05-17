using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cube3D
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(":");
        }

        Console.WriteLine();

        for (int j = 0; j < n - 1; j++)
        {
      
            for (int i = 0; i < n; i++)
            {
                if (j == n - 2) { break; }
                if (i == 0 || i == n - 1) { Console.Write(":"); }
                else                      { Console.Write(" "); }
            }

            if (j == n - 2)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(":");
                }
            }

            for (int i = 0; i < j + 1; i++)
            {
                if (i == j) {Console.Write(":");}
                else        {Console.Write("|");}
            }

            Console.WriteLine();
        }

        for (int j = 0; j < n - 2; j++)
        {
            for (int i = 0; i < j + 1; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1) { Console.Write(":"); }
                else { Console.Write("-"); }
            }

            for (int i = n - 1; i > j + 1 ; i--)
            {
                if (i != j + 2) { Console.Write("|"); }
                else { Console.Write(":"); }
            }

            Console.WriteLine();
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(":");
        }

        Console.WriteLine();
        Console.WriteLine();
        
    }
}