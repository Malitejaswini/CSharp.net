using System;
using System.Collections.Generic;
using System.Text;

namespace OP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g;
            Console.WriteLine("Enter 1st no.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd no.");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            g = a % b;
            Console.WriteLine("Addition : "+c+"\nSubtraction : "+d+"\nMultiplication : "+e+"\nDivision : "+f+"\nMod : "+g);
        }
    }
}
