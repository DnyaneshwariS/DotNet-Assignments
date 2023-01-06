using System;
using System.Collections.Generic;
using System.Text;

namespace Ass_3._1
{
    [Serializable]
    class MarketingExecutive : Emplyoee, Interface1
    { 
        public MarketingExecutive(int EmpNo, string EmpName, double Salaray) : base(EmpNo, EmpName, Salaray)
            {
                
            }
        double Kilometer_travel;
        double TourAllowance;
        double TelephoneAllowance;
        double Grosssalary;
        public void MEGrossSalary()
        {
            Console.WriteLine("Enter km");
            Kilometer_travel = Convert.ToDouble(Console.ReadLine());
            TourAllowance = 5 * Kilometer_travel;
            TelephoneAllowance = 1000;

            Grosssalary = Salaray + hra + ta + da + TelephoneAllowance + TourAllowance;
            Console.WriteLine(Grosssalary);
        }
        public override void CalculateSalary()
        {
            pf = 0.1 * GrossSalary;
            Console.WriteLine("Pf is" + pf);
            tds = 0.18 * GrossSalary;
            Console.WriteLine("tds is " + tds);
            NetSalaray = Grosssalary - (pf - tds);
            Console.WriteLine("netsalary is " + NetSalaray);
        }
        public void Display()
        {
            Console.WriteLine("Emp id is " + EmpNo);
            Console.WriteLine("Emp name is " + EmpName);
            Console.WriteLine("emp salaray is " + Salaray);
        }
    }
}
