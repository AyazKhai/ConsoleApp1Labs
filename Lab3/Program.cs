using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerSuply Ecovolt = new PowerSuply("Ecovolt", "Termo312", 300, 13300);
            RezervSuply Luduvi = new RezervSuply("Luduvi", "90000", 90000, 11820, 48);
            Console.WriteLine(Ecovolt.GetReport());
            Console.WriteLine(Luduvi.GetReport());

            Console.ReadKey();
        }
    }
}
public class PowerSuply
{
    public string firm = "Undefind";
    public string mark = "Undefind";
    public int capcity = 0;
    public int cost = 0;

    private int id;

    public PowerSuply() { }
    public PowerSuply(string firm, string mark, int capacity, int cost)
    {
        this.firm = firm;
        this.mark = mark;
        this.capcity = capacity;
        this.cost = cost;
    }

    public virtual string GetReport() 
    {
        return $"Источник бесперебойного питания:(Родитель)\nФирма: {firm}\nМарка: {mark}\nЁмкость: {capcity} мАч\nЦена: {cost} руб.\n";
    }

}

public class RezervSuply : PowerSuply 
{
    public int worktime = 0;
    public RezervSuply() { }    
    public RezervSuply(string firm, string mark, int capacity, int cost,int worktime) 
    {
        this.firm = firm;
        this.mark = mark;
        this.capcity = capacity;
        this.cost = cost;
        this.worktime = worktime;
    }
    public override string GetReport()
    {
        return $"Источник автономного питания:(Наследник)\nФирма: {firm}\nМарка: {mark}\nЁмкость: {capcity} мАч \nЦена: {cost} руб.\nВремя автономной работы: {worktime} часов\n";
    }

}