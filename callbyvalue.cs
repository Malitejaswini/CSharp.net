using System;
using System.Collections.Generic;
using System.Text;

namespace callbyvalue
{
   public class c1
    {
        public void read(int a, int b)
        {
            Console.WriteLine("Addition is:- "+(a+b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            c1 c = new c1();
            c.read(10,10);
            Console.ReadLine();
        }
    }
}
