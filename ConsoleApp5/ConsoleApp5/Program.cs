using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int start;
            int end;
            Console.WriteLine("enter the starting number and ending number to find the sum");
             start=Convert.ToInt32( Console.ReadLine());
            end = Convert.ToInt32(Console.ReadLine());
            int num = (start - end);
            int a= num / 2;
           thread th1=new thread(new ThreadStart(th))
            

            Console.ReadLine();

        }
        
    }
    class thread
    {
         public static void part1(int a)
        {

        }
    }
}
