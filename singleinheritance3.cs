/* 
 * Que:- Program to check whether given number is positive or negative using single inheritance.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace nopn
{
       public class p1
{
 public int n;
  public void read()
  {
    Console.WriteLine("Enter the no:-");
    n=Convert.ToInt32(Console.ReadLine());
  }
}
public class p2:p1
{
  public void display()
  { 
    if(n>0)
    {
      Console.WriteLine("Number is positive");
    }
    else
    {
      Console.WriteLine("Number is negative");
    }
  }
}
   public class Program
   {
     public static void Main(string[] args)
     {
       p2 p=new p2();
       p.read();
       p.display();
       Console.ReadLine();
     }
   }
 }

