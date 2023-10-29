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
            queues test1 = new queues(n);
            queues test2 = new queues(n);
            queues test3 = new queues(n);
            queues test4 = new queues(n);
            queues test5 = new queues(n);

            test1.GetIds();
            test2.GetIds();
            test3.GetIds();
            test4.GetIds();
            test5.GetIds();


            Console.WriteLine("\nSORTEEEDDD\n");

            Sorts.Bubbly(test1);
            Sorts.ShallSort(test2);
            Sorts.ShakerSort(test3);
            Sorts.DirectChoose(test4);
            Sorts.DirectConnection(test5);

            test1.GetIds(); 
            test2.GetIds(); 
            test3.GetIds(); 
            test4.GetIds(); 
            test5.GetIds(); 

            Console.ReadKey();
        }
    }
}





