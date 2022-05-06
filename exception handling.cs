using System;
using System.Collections.Generic;
using System.Text;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10,b=0,c;
            try
            {
                c=a/b;
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Exception is:- "+e);
            }
            Console.ReadLine();
        }
    }
}
