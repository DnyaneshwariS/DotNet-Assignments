using System;
using System.Collections.Generic;
using System.Text;

namespace Ass_3._1
{
    [Serializable]
    class Manager : Emplyoee,Interface1
    {
        double petrolAllowance;
        double foodAllowance;
        double otherAllowance;
        double grossSalaray;
        
        
        public void GROSSSALARAY()
        {
            petrolAllowance = 0.08 * Salaray;
            foodAllowance = 0.13 * Salaray;
            otherAllowance = 0.03 * Salaray;
            grossSalaray = Salaray + hra + ta + da + petrolAllowance + foodAllowance + otherAllowance;
            Console.WriteLine(grossSalaray);
        }
        public override void CalculateSalary()
        {
            pf = 0.1 * GrossSalary;
            Console.WriteLine("Pf is" + pf);
            tds = 0.18 * GrossSalary;
            Console.WriteLine("tds is "+ tds);
            NetSalaray = GrossSalary - (pf - tds);
            Console.WriteLine("netsalary is " + NetSalaray);
        }
        public Manager(int EmpNo, string EmpName, double Salaray) : base(EmpNo, EmpName, Salaray)
        {

        }


        public void  Display()
        {
            Console.WriteLine("Emp id is " + EmpNo);
            Console.WriteLine("Emp name is " + EmpName);
            Console.WriteLine("emp salaray is " + Salaray);
        }

    }
}
