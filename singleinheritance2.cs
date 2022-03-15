/*
 Que:- Program to display rectangle from given length and width using single inheritance. 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace singleinheitance2
{
    public class a1
    {
        public int l, b;
        public void read()
        {
            Console.WriteLine("Enter the Length of Reactangle:- ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Reactangle:- ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class a2 : a1
    {
        int area;
        public void calculate()
        {
            area = l * b;
            Console.WriteLine("Area of rectangle is:-" + area);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            a2 a = new a2();
            a.read();
            a.calculate();
            Console.ReadLine();
        }
    }

}
