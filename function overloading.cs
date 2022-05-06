using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class c1
    {
        public void read(int a)
        {
            Console.WriteLine("Square of " + a + " is " + a * a);
        }
        public void read(int a, int b)
        {
            Console.WriteLine("Addtion of " + a + " & " + b + " is " + (a + b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            c1 c = new c1();
            c.read(2);
            c.read(2, 4);
            Console.ReadLine();
        }
    }
}
