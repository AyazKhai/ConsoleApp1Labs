using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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


            Stopwatch BubblyTest = new Stopwatch();
            test1.GetIds();
            BubblyTest.Start();
            Sorts.BubblyId(test1);
            BubblyTest.Stop();
            test1.GetIds();
            Console.WriteLine($" Время сортировки пузырька {BubblyTest.ElapsedTicks}\n");


            Stopwatch ShallTest = new Stopwatch();
            test2.GetIds();
            ShallTest.Start();
            Sorts.ShallSortId(test2);
            ShallTest.Stop();
            test2.GetIds();
            Console.WriteLine($" МЕтод Шела {ShallTest.ElapsedTicks}\n");


            Stopwatch ShakerTest = new Stopwatch();
            test3.GetIds();
            ShakerTest.Start();
            Sorts.ShakerSortId(test3);
          
            ShakerTest.Stop();
            test3.GetIds();
            Console.WriteLine($" МЕтод Шейкерной сортировки {ShakerTest.ElapsedTicks} \n");

            Stopwatch DirectChooseTest = new Stopwatch();
            test4.GetIds();
            DirectChooseTest.Start();
            Sorts.DirectChooseId(test4);
            DirectChooseTest.Stop();
            test4.GetIds();
            Console.WriteLine($" Метод DirectChoose {DirectChooseTest.ElapsedTicks}\n");

            Stopwatch DirectConnectionTest = new Stopwatch();
            test5.GetIds();
            DirectConnectionTest.Start();
            Sorts.DirectConnectionId(test5);
           
            DirectConnectionTest.Stop();
            test5.GetIds();
            Console.WriteLine($" DirectConnection {DirectConnectionTest.ElapsedTicks} \n");
          

            Console.ReadKey();
        }
    }
}





