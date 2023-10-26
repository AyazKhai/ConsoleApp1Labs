using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class queues
    {

        public PowerSuply[] Queues = new PowerSuply[30];
        public queues(int n)
        {
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
                {

                    return Queues[pos];

                }

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
            for (int i = 0; i < Queues.Length; i++)
            {
                Console.WriteLine($"Источник автономного питания:\nФирма: {Queues[i].firm}\nМарка: {Queues[i].mark}\nИдентифиционный номер: {Queues[i].id}\n");
            }

        }
    }
    public class PowerSuply
    {
        public string firm;
        public string mark;
        public int id;

        private string[] firmArr = new string[6] { "CyberPower", "IPPON", "El-Power", "Philips", "Panasonic", "samsung" };
        private string[] markArr = new string[4] { "Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)", "с двойным преобразованием напряжения(On-Line)", "Cломанный" };

        public PowerSuply()
        {
            Random random = new Random();
            int t = random.Next(0, firmArr.Length);
            int t2 = random.Next(0, markArr.Length);
            firm = firmArr[t];
            mark = markArr[t2];
            Random idRan = new Random();
            id = idRan.Next(100);

        }

    }

    public class Sorts
    {
        public static void DirectChoose(queues arr)
        {

            int min = -1;
            int jDub = 0;
            PowerSuply ghost = new PowerSuply();
            for (int i = 0; i < arr.Queues.Length; i++) 
            {
                for (int j = i+1; j < arr.Queues.Length-1; j++) 
                {
                    if (arr[j].id < min) 
                    {
                        min = arr[j].id;
                        jDub = j;
                    }
                }
                ghost = arr[jDub];
                arr[jDub] = arr[i];
                arr[i] = ghost;
            }
        }
    } 
    

    
}
