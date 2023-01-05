using System;
using System.Collections.Generic;
namespace Assignment5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> my_list = new LinkedList<String>();
            my_list.AddLast("Dnyaneshwari");
            my_list.AddLast("Kamaksha");
            my_list.AddLast("Anita");
            my_list.AddLast("Sujita");
            my_list.AddLast("Vishakha");
            my_list.AddLast("Bithi");

            Console.WriteLine("List of Employees:");

           
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Number of Emplyoees  "+
                                     my_list.Count);
            
        }
    }
}
