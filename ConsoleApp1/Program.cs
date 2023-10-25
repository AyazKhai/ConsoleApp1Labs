
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ёмкость источника бесперибойного питания: " + PowerSuply.capcity);
            Console.WriteLine("Название фирмы: " + PowerSuply.firm);
            Console.ReadKey();
        }
    }
}
public class PowerSuply
{
    public static string firm = "Samsung";
    public string mark = "Z310Dual";
    public static int capcity = 3000;

    private int id;
}