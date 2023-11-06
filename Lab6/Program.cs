using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    internal class Program
    {

        BinaryFormatter sw = new BinaryFormatter();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
 
            queues test0 = new queues(n);
            
            queues test1 = new(n);
            queues test2 = new(n);
            queues test3 = new(n);
            queues test4 = new(n);
            queues test5 = new(n);

            test0.CopyTo(test1);
            test0.CopyTo(test2);
            test0.CopyTo(test3);
            test0.CopyTo(test4);
            test0.CopyTo(test5);
            // Sorts.ResultsTicks(test1, Sorts.TypeSorts.one);

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

            ///////////////
            Console.WriteLine("\n");
            ///
            Stopwatch BubblyTestFirm = new Stopwatch();
            test1.GetFirm();
            BubblyTestFirm.Start();
            Sorts.BubblyFirm(test1);
            BubblyTestFirm.Stop();
            test1.GetFirm();
            Console.WriteLine($" Время сортировки пузырька {BubblyTestFirm.ElapsedTicks}\n");


            Stopwatch ShallTestFirm = new Stopwatch();
            test2.GetFirm();
            ShallTestFirm.Start();
            Sorts.ShallSortFirm(test2);
            ShallTestFirm.Stop();
            test2.GetFirm();
            Console.WriteLine($" МЕтод Шела {ShallTestFirm.ElapsedTicks}\n");


            Stopwatch ShakerTestFirm = new Stopwatch();
            test3.GetFirm();
            ShakerTestFirm.Start();
            Sorts.ShakerSortFirm(test3);

            ShakerTestFirm.Stop();
            test3.GetFirm();
            Console.WriteLine($" МЕтод Шейкерной сортировки {ShakerTestFirm.ElapsedTicks} \n");

            Stopwatch DirectChooseTestFirm = new Stopwatch();
            test4.GetFirm();
            DirectChooseTestFirm.Start();
            Sorts.DirectChooseFirm(test4);
            DirectChooseTestFirm.Stop();
            test4.GetFirm();
            Console.WriteLine($" Метод DirectChoose {DirectChooseTestFirm.ElapsedTicks}\n");

            Stopwatch DirectConnectionTestFirm = new Stopwatch();
            test5.GetFirm();
            DirectConnectionTestFirm.Start();
            Sorts.DirectConnectionFirm(test5);

           // test5.GetRes();
            DirectConnectionTestFirm.Stop();
            test5.GetFirm();
            Console.WriteLine($" DirectConnection {DirectConnectionTestFirm.ElapsedTicks} \n");
           // test5.GetRes();

            Console.ReadKey();
        }
    }
}





