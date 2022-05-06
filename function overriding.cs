using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class c1
    {
        public void read(int a,int b)
        {
            Console.WriteLine("Addition of" + a + " & " + b+ " is "+(a+b));
        }
    }
    public class c2:c1
    {
        public void read(int a, int b)
        {
            Console.WriteLine("Multiplicatin of " + a + " & " + b + " is " + (a * b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            c2 c = new c2();
            c.read(3,3);
            Console.ReadLine();
        }
    }
}
