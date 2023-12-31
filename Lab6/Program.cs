﻿using System;
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

       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            queues test0 = new(n);

            queues test1 = new(n); test0.CopyTo(test1);
            queues test2 = new(n); test0.CopyTo(test2);
            queues test3 = new(n); test0.CopyTo(test3);
            queues test4 = new(n); test0.CopyTo(test4);
            queues test5 = new(n);test0.CopyTo(test5);

            test1.GetIds();
            Sorts.DirectChooseId(test1);
            //test1.GetRes("\n");

            test2.GetIds();
            Sorts.BubblyId(test2);
           // test2.GetRes("\n");

            test3.GetIds();
            Sorts.DirectConnectionId(test3);
           // test3.GetRes("\n");

            test4.GetIds();
            Sorts.ShakerSortId(test4);
          // test4.GetRes("\n");

            test5.GetIds();
            Sorts.ShallSortId(test5);
          //  test5.GetRes("\n");

            Console.WriteLine("\n");

            test1.GetFirm();
            Sorts.DirectChooseFirm(test1);
           // test1.GetRes("\n");

            test2.GetFirm();
            Sorts.BubblyFirm(test2);
          //  test2.GetRes("\n");

            test3.GetFirm();
            Sorts.DirectConnectionFirm(test3);
          //  test3.GetRes("\n");

            test4.GetFirm();
            Sorts.ShakerSortFirm(test4);
          //  test4.GetRes("\n");

            test5.GetFirm();
            Sorts.ShallSortFirm(test5);
           // test5.GetRes("\n");

            Console.ReadKey();
        }

    }
}





