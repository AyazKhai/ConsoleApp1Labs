﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    [Serializable]
    public class PowerSuply
    {
        public string firm;
        public string mark;
        public string id;

        private string[] firmArr = new string[6] { "CyberPower", "IPPON", "El-Power", "Philips", "Panasonic", "samsung" };
        private string[] markArr = new string[4] { "Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)", "с двойным преобразованием напряжения(On-Line)", "Cломанный" };

        public PowerSuply()
        {
            Random random = new Random();
            int t = random.Next(0, firmArr.Length);
            int t2 = random.Next(0, markArr.Length);
            firm = firmArr[t];
            mark = markArr[t2];
            id = Guid.NewGuid().ToString("n");
            //only "D", "d", "N", "n", "P", "p", "B", "b", "X" or "x"."
        }
       
    }
    [Serializable]
    public class queues 
    {
        private readonly int n = 1;
        PowerSuply[] Queues = new PowerSuply[30];
        public queues() 
        {
            for (int i = 0; i < n; i++)
            {
                Queues[i] = new PowerSuply();
            }
        }
        public queues(int n) 
        { 
            this.n = n;
            for (int i = 0; i < n; i++)
            {
                Queues[i] = new PowerSuply();
            }
        }
        
        public PowerSuply this[int pos]
        {
            get
            {

                if (pos >= 0 && pos < 30)
                    return Queues[pos];
                else
                {
                    throw new IndexOutOfRangeException("Вне диапазона");
                }
            }
            set
            {
                Queues[pos] = value;
            }
        }

        public void GetRes()
        {
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine($"Источник автономного питания:\nФирма: {Queues[i].firm}\nМарка: {Queues[i].mark}\nИдентифиционный номер: {Queues[i].id}\n");
            }
         
        }
    }
}