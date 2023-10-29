using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
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
            //only "D", "d", "N", "n", "P", "p", "B", "b", "X" or "x"."
        }

    }
    public class queues
    {
        private readonly int n = 1;
        public PowerSuply[] Queues;

        public queues()
        {
            Queues = new PowerSuply[n];
            for (int i = 0; i < n; i++)
            {
                Queues[i] = new PowerSuply();
            }
        }
        public queues(int n)
        {
            this.n = n;
            Queues = new PowerSuply[n];
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

        public void GetIds() 
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Queues[i].id} ");
            }
        }
    }

    public class Sorts
    {
        public static void DirectChoose(queues arr)
        {
            PowerSuply ghost = new PowerSuply();
            for (int i = 0; i < arr.Queues.Length-1; i++)
            {

                int minIndex = i;
                for (int j = i + 1; j < arr.Queues.Length; j++)
                {
                    if (arr[j].id < arr[minIndex].id)
                    {
                        minIndex = j;
                    }
                    if(minIndex != i) 
                    {
                        ghost = arr[minIndex]; 
                        arr[minIndex] = arr[i]; 
                        arr[i] = ghost;
                    }

                }

            }
        }

        public static void Bubbly(queues arr) 
        {
            PowerSuply ghost = new PowerSuply();
            bool swapped;
            for (int j = 0; j < arr.Queues.Length-1; j++)
            {
                swapped = false;
                for (int i = 0; i < arr.Queues.Length - 1; i++)
                {
                    
                    if (arr[i + 1].id < arr[i].id)
                    {
                        ghost = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = ghost;
                        swapped = true;
                    }

                }
                if(!swapped) { break; }

            }
            
        }
        public static void DirectConnection(queues arr) 
        {
            PowerSuply ghost = new PowerSuply();
            for (int i = 0; i<arr.Queues.Length; i++) 
            {
                int value = arr[i].id;//// Значение id текущего элемента
                int index = i;// Его индекс в массиве 
                while ((index > 0) && (arr[index - 1].id > value)) // Цикл, выполняющий сдвиг элементов влево, пока предшествующий элемент больше текущего
                {
                    ghost = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = ghost;
                    index--;
                }
                //arr[index].id = value;// Присвоение текущему элементу значения id
            }
        }
    }
}

