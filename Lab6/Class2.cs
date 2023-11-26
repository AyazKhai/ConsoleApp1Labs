using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    [Serializable]
    public class PowerSuply
    {
        public string firm;
        public string mark;
        public int id;

        private string[] firmArr = new string[13] { "CyberPower", "IPPON", "El-Power", "Philips", "Panasonic", "samsung",
            "ЗИТ","ИМПУЛЬС","Парус электро", "РОТЕК", "ТК Профэнерджи", "Электромаш", "QTECH" };
        private string[] markArr = new string[4] { "Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)",
            "с двойным преобразованием напряжения(On-Line)", "Cломанный" };

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
    [Serializable]
    public class queues
    {
        public readonly int n = 1;
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

        public void GetRes()//выводит результат(все поля объекта в строчку
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Фирма: {Queues[i].firm}; Марка: {Queues[i].mark}; Идентифиционный номер: {Queues[i].id}");
            }

        }
        public void GetRes(string str)//выводит результат(все поля объекта в строчку
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Фирма: {Queues[i].firm}; Марка: {Queues[i].mark}; Идентифиционный номер: {Queues[i].id}");
            }
            Console.Write(str);
        }
        public void GetIds() //выводит поля id 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Queues[i].id} ");
            }
            Console.WriteLine();
        }
        public void GetIds(string str) //выводит поля id 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Queues[i].id} ");
            }
            Console.WriteLine(str);
        }
        public void GetFirm()//выводит поля firm
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Queues[i].firm} ");
            }
            Console.WriteLine();

        }
        public void GetFirm(string str)//выводит поля firm
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Queues[i].firm} ");
            }
            Console.WriteLine(str);
        }

        public void CopyTo(queues obj1) 
        {
            for (int i = 0; i < n; i++) 
            {
                obj1.Queues[i].id = this.Queues[i].id;
                obj1.Queues[i].firm = this.Queues[i].firm;
                obj1.Queues[i].mark = this.Queues[i].mark;
            }
        }

    }

    public class Sorts
    {
        public static void DirectChooseId(queues arr)
        {

           Stopwatch stopwatch = Stopwatch.StartNew();
            PowerSuply ghost = new PowerSuply();
            for (int i = 0; i < arr.Queues.Length - 1; i++)
            {

                int minIndex = i;
                for (int j = i; j < arr.Queues.Length; j++)
                {
                    if (arr[j].id < arr[minIndex].id)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    ghost = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = ghost;
                }
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод DirectChoose {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }
        public static void DirectChooseFirm(queues arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            PowerSuply ghost = new PowerSuply();
            for (int i = 0; i < arr.Queues.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Queues.Length; j++)
                {
                    if (arr[j].firm.CompareTo(arr[minIndex].firm)<0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    ghost = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = ghost;
                }

            }
            stopwatch.Stop();
            Console.WriteLine($" Метод DirectChoose {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }
        
        public static void BubblyId(queues arr) 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
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
            stopwatch.Stop();
            Console.WriteLine($" Метод Bubbly {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");

        }
        public static void BubblyFirm(queues arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            PowerSuply ghost = new PowerSuply();
            bool swapped;
            for (int j = 0; j < arr.Queues.Length - 1; j++)
            {
                swapped = false;
                for (int i = 0; i < arr.Queues.Length - 1; i++)
                {

                    if (arr[i + 1].firm.CompareTo(arr[i].firm)<0)
                    {
                        ghost = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = ghost;
                        swapped = true;
                    }

                }
                if (!swapped) { break; }

            }
            stopwatch.Stop();
            Console.WriteLine($" Метод Bubbly {stopwatch.Elapsed.TotalMilliseconds} ");

        }

        public static void DirectConnectionId(queues arr) 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
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
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод DirectConnection {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }
        public static void DirectConnectionFirm(queues arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            PowerSuply ghost = new PowerSuply();
            for (int i = 0; i < arr.Queues.Length; i++)
            {
                string value = arr[i].firm;//// Значение firm текущего элемента
                int index = i;// Его индекс в массиве 
                while ((index > 0) && (arr[index - 1].firm.CompareTo(value)>0)) // Цикл, выполняющий сдвиг элементов влево, пока предшествующий элемент больше текущего
                {
                    ghost = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = ghost;
                    index--;
                }
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод DirectConnection {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }

        public static void ShakerSortId(queues arr) 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool swapped = true;// Флаг, означающий, что произошла перестановка элементов
            int start = 0;
            int end = arr.Queues.Length - 1;
            PowerSuply ghost = new PowerSuply();

            while (swapped)
            {
                swapped = false;

                // Проход слева направо
                for (int i = start; i < end; i++)
                {
                    if (arr[i].id > arr[i + 1].id)// Если предыдущий элемент больше следующего, меняем их местами
                    {
                        ghost = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = ghost;
                        swapped = true;
                    }
                }
                if (!swapped)// Если на проходе не было перестановок, массив уже отсортирован
                {
                    break;
                }
                swapped = false;
                end--;
                // Проход справа налево
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i].id > arr[i + 1].id)// Если предыдущий элемент больше следующего, меняем их местами
                    {
                        ghost = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = ghost;
                        swapped = true;
                    }
                }
                start++;
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод ShakerSort {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }
        public static void ShakerSortFirm(queues arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool swapped = true;// Флаг, означающий, что произошла перестановка элементов
            int start = 0;
            int end = arr.Queues.Length - 1;
            PowerSuply ghost = new PowerSuply();

            while (swapped)
            {
                swapped = false;

                // Проход слева направо
                for (int i = start; i < end; i++)
                {
                    if (arr[i].firm.CompareTo(arr[i+1].firm)>0)// Если предыдущий элемент больше следующего, меняем их местами
                    {
                        ghost = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = ghost;
                        swapped = true;
                    }
                }

                if (!swapped)// Если на проходе не было перестановок, массив уже отсортирован
                {
                    break;
                }

                swapped = false;
                end--;

                // Проход справа налево
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i].firm.CompareTo(arr[i + 1].firm) > 0)// Если предыдущий элемент больше следующего, меняем их местами
                    {
                        ghost = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = ghost;
                        swapped = true;
                    }
                }

                start++;
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод ShakerSort {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }

        public static void ShallSortId(queues arr) 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = arr.Queues.Length;
            PowerSuply ghost = new PowerSuply();

            // Выбор шага
            int gap = n / 2;

            // Пока шаг больше 0
            while (gap > 0)
            {
                // Выполняем сортировку вставками с заданным шагом
                for (int i = gap; i < n; i++)
                {
                    ghost = arr[i];
                    int j = i;

                    // Сдвигаем элементы на шаг назад, пока не найдем место для вставки
                    while (j >= gap && arr[j - gap].id > ghost.id)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = ghost;
                }
                // Уменьшаем шаг
                gap /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод ShallSort {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }
        public static void ShallSortFirm(queues arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = arr.Queues.Length;
            PowerSuply ghost = new PowerSuply();

            // Выбор шага
            int gap = n / 2;

            // Пока шаг больше 0
            while (gap > 0)
            {
                // Выполняем сортировку вставками с заданным шагом
                for (int i = gap; i < n; i++)
                {
                    ghost = arr[i];
                    int j = i;

                    // Сдвигаем элементы на шаг назад, пока не найдем место для вставки
                    while (j >= gap && (arr[j-gap].firm.CompareTo(ghost.firm)>0))
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = ghost;
                }
                // Уменьшаем шаг
                gap /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine($" Метод ShallSort {stopwatch.Elapsed.TotalMilliseconds} миллисекунд ");
        }
    }
}


