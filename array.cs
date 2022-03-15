using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a=new int[10];
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Elements are:-");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }
                Console.ReadLine();
        }
    }
}
