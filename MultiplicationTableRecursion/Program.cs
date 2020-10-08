using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableRecursion
{
    class Program
    {
        //static void Multiplication(int a, int b)
        //{
        //    if (b > 10)
        //        return;
        //    Console.WriteLine(a + "*" + b + "=" + a * b);
        //    Multiplication(a, b + 1);
        //}
        static void Multiplication(int a, int b)
        {
            if (b > 0)
            {
                Multiplication(a, b - 1);
                Console.WriteLine(a + "*" + b + "=" + a * b);
            }
            return;
        }
        //static void print(int a)
        //{
        //    if (a > 0)
        //    {
        //    print(a - 1);
        //    Console.WriteLine(a + "");
        //    }

        //    return;
        //}

        static void Main(string[] args)
        {
            //int a = 2;
            //Multiplication(a, 1);
            //print(10);
            int a = 2;
            Multiplication(a, 10);
            Console.ReadKey();
        }
    }
}
