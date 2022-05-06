using System;
using System.Collections.Generic;
using System.Text;

namespace callbyreference
{
    class Program
    {
        void get(ref int x)
        {
            x = 10;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int x = 20;
            Program p = new Program();
            Console.WriteLine("Before Function Call:- "+x);
            p.get(ref x);
            Console.WriteLine("After Function call:- "+x);
            Console.ReadLine();
        }
    }
}
