using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            queues a = new queues(n);
            a.GetIds();

            Console.WriteLine("\nSORTEEEDDD\n");

            Sorts.DirectChoose(a);
            a.GetIds();

            Console.ReadKey();
        }
    }
}





