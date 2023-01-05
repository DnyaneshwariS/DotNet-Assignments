using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(2);
            a1.Add("Dnyaneshwari");
            a1.Add("Manager");

            ArrayList a2 = new ArrayList();
            a2.Add( 3);
            a2.Add("Kamaksha");
            a2.Add("Marketing Executive");

            ArrayList a3 = new ArrayList();
            a3.Add(4);
            a3.Add("Anita");
            a3.Add("Engineer");



            Console.WriteLine("Emp id is " +a1[0]+" Emp name is "+a1[1] +"emp designation is "+a1[2]);
           

            Console.WriteLine(a2[0]);
            Console.WriteLine(a2[1]);
            Console.WriteLine(a2[2]);

            Console.WriteLine(a3[0]);
            Console.WriteLine(a3[1]);
            Console.WriteLine(a3[2]);
            Console.ReadKey();
        }
    }
}