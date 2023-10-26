using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            queues a = new queues(n);
            

            for(int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Источник автономного питания:\nФирма: {a[i].firm}\nМарка: {a[i].mark}\nИдентифиционный номер: {a[i].id}\n");
            }
            Console.ReadKey();
        }
    }
}

class queues
{
    PowerSuply[] Queues = new PowerSuply[30];
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
}
public class PowerSuply
{
    public string firm;
    public string mark;
    public int id;
 
    private string[] firmArr = new string[6] { "CyberPower", "IPPON", "El-Power", "Philips","Panasonic","samsung" };
    private string[] markArr = new string[4] { "Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)", "с двойным преобразованием напряжения(On-Line)","Cломанный" };

    public PowerSuply() 
    {
        Random random = new Random();
        int t = random.Next(0, firmArr.Length);
        int t2 = random.Next(0, markArr.Length);
        firm = firmArr[t];
        mark = markArr[t2];
        Random idRan = new Random();
        id = idRan.Next(30);

    }
    
}

 