using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestEmp
{
   public class Empl
    {
        public int EmpNo;
        string EmpName;
        double Salaray, hra, da, ta, pf, tds, NetSalaray, GrossSalary;
        //set property
        //public int EMPNO { get; set; }
        //public string EMPNAME { get; set; }
        //public double SALARAY { get; set; }
        /*public int HRA { get; set; }
        public int DA { get; set; }
        public int TA { get; set; }
        public int PF { get; set; }
        public int TDS { get; set; }
        public int NETSALARAY { get; set; }
        public int GROSSSALARAY { get; set; }*/


        //constructor
        public Empl (int EmpNo,string EmpName,double Salaray)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salaray = Salaray;
        }
        public Empl()
        {
            this.EmpNo = 100;
        }
        //methods
        public void HRACalculate(double Salaray)
        {
            if (Salaray < 5000)
            {
                hra = 0.1 * Salaray;
            }
            else if (Salaray < 10000)
            {
                hra = 0.15 * Salaray;
            }
            else if (Salaray < 15000)
            {
                hra = 0.20 * Salaray;
            }
            else if (Salaray < 20000)
            {
                hra = 0.25 * Salaray;
            }
            else
            {
                hra = 0.30 * Salaray;
            }

        }
        public void TACalculator(double Salaray)
        {

            if (Salaray < 5000)
            {
                ta = 0.05 * Salaray;
            }
            else if (Salaray < 10000)
            {
                ta = 0.10 * Salaray;
            }
            else if (Salaray < 15000)
            {
                ta = 0.15 * Salaray;
            }
            else if (Salaray < 20000)
            {
                ta = 0.20 * Salaray;
            }
            else
            {
                ta = 0.25 * Salaray;
            }
        }
        public void DACalculator(double Salaray)
        {
            if (Salaray < 5000)
            {
                da = 0.15 * Salaray;
            }
            else if (Salaray < 10000)
            {
                da = 0.20 * Salaray;
            }
            else if (Salaray < 15000)
            {
                da = 0.25 * Salaray;
            }
            else if (Salaray < 20000)
            {
                da = 0.30 * Salaray;
            }
            else
            {
                da = 0.35 * Salaray;
            }
        }
        public void GrossSalaray()
        {
            GrossSalary = Salaray + hra + ta + da;
            Console.WriteLine(GrossSalary);

        }
        public void PFCalculator()
        {
            pf = 0.1 * GrossSalary;
            Console.WriteLine(pf);
        }
        public void TDSCalculator()
        {
            tds = 0.18 * GrossSalary;
            Console.WriteLine(tds);
        }
        public void NetSalary()
        {
            NetSalaray = GrossSalary - (pf + tds);
            Console.WriteLine(NetSalaray);
        }
        public void Display()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salaray);
            Console.WriteLine(hra);
            Console.WriteLine(ta);
            Console.WriteLine(da);
            Console.WriteLine(GrossSalary);
            Console.WriteLine(pf);
            Console.WriteLine(tds);
            Console.WriteLine(NetSalaray);

        }
  
    }
    class Lib
    {
        public static void Main(string[]args)
        {
            Empl emp = new Empl(1, "Dnyaneshwari", 5000);
            emp.HRACalculate(5000);
            emp.TACalculator(5000);
            emp.DACalculator(5000);
            emp.GrossSalaray();
            emp.PFCalculator();
            emp.TDSCalculator();
            emp.NetSalary();
            emp.Display();
        }
    }
}
