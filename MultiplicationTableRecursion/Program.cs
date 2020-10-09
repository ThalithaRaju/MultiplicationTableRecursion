using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiplicationTableRecursion
{
    class Program
    {
       static int i=1;
        static int l;
        static int m;
        static void Multiplication()
        {
            if (i<=l)
            {
                Thread.Sleep(500);
                Console.WriteLine( i+"" +"X"+ m + "=" +i * m);
                i++;
                Multiplication();
            }
            return; 
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter multiplier");
             m = Convert.ToInt32(Console.ReadLine());
            Multiplication();
            Console.ReadKey();
        }
    }
}
