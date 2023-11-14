 using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;




namespace Lab5._3
{
    
   
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            queues q2 = new queues(n);
            q2.GetRes();

            BinaryFormatter sw = new BinaryFormatter();
            //Серелизация
            using (FileStream fs = new FileStream("File_queue.txt", FileMode.Create, FileAccess.Write))
            {
                sw.Serialize(fs, q2);
                Console.WriteLine($"Object has been serilized\n");
            }
            Console.ReadKey();
            queues q1 = new();
            //Десерилизация
            using (FileStream fs = new FileStream("File_queue.txt", FileMode.Open, FileAccess.Read))
            {
                
                while (fs.Position < fs.Length)
                {
                    q1 = (queues)sw.Deserialize(fs); 
                    Console.WriteLine($"Object has been deserialized\n");
                }
            }
            q1.GetRes();
            Console.ReadLine();

        }
    }
   

}



