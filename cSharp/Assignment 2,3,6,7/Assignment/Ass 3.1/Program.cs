using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ass_3._1
{
    class Program
    {
        public static void SerializeObject(Object o)
        {
            FileStream fs = new FileStream(@"C:\Users\DNSURYAV\DotNet-Assignments\cSharp\assignment3\Ass 3.1\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, o);
            fs.Close();
        }

        public static void DeserializeObject()
        {
            FileStream fs = new FileStream(@"C:\Users\DNSURYAV\DotNet-Assignments\cSharp\assignment3\Ass 3.1\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Manager m1 = new Manager(12,"bithi",20000);
            m1 = (Manager)formatter.Deserialize(fs);
            Console.WriteLine($"-----Printing DeSerialized Manager Object-----\n{m1}");
            fs.Close();
        }





        static void Main(string[] args)
        {
            /*Emplyoee emp = new Emplyoee(100, "dnyana", 1000);
            emp.Display();
           Emplyoee mg = new Manager(200, "kama", 10000);
            mg.Display();*/
            Manager m = new Manager(100, "Dnyana", 30000);
            m.GROSSSALARAY();
            m.CalculateSalary();
            SerializeObject(m);
            DeserializeObject();

        }
    }
}
