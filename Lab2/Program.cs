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
            PowerSuply Myown = new PowerSuply();

            Console.WriteLine("Название источника бесперебойного питания из магазина "+Ecovolt.firm + " "+Ecovolt.mark);
            Console.WriteLine("Название домашнего источника бесперебойного питания " + Myown.firm + " " + Myown.mark);
            Console.ReadKey();
        }
    }
}
public class PowerSuply
{
    public string firm = "Undefind";
    public string mark = "Undefind";
    public int capcity= 0;
    public int cost = 0;
    private int id;

    public PowerSuply() { }
    public PowerSuply(string firm,string mark, int capacity, int cost)
    {
        this.firm = firm;
        this.mark = mark;
        this.capcity = capacity;
        this.cost = cost;
    }

}