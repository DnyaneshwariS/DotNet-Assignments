using System;
using System.Collections.Generic;
using System.Text;

namespace Ass_3._1
{
    [Serializable]
    class Emplyoee
    {
       public int EmpNo;
        public string EmpName;
        public double Salaray, hra, da, ta, pf, tds, NetSalaray, GrossSalary;
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
        public Emplyoee(int EmpNo, string EmpName, double Salaray)
        {
            if(EmpNo <= 0)
            {
                throw new Exception("Empty");
            }
            else
            {
                this.EmpNo = EmpNo;
            }
            if(string.IsNullOrEmpty(EmpName))
            {
                throw new Exception("Emp Name emoty");
              
            }

            else
            {
                this.EmpName = EmpName;
            }
            if(Salaray<=0)
            {
                throw new Exception("Salary emoty");
            }
            else
            {
                this.Salaray = Salaray;
            }
           
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
            Console.WriteLine("HRA is " + hra);
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
            Console.WriteLine("TA is" + ta);
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
            Console.WriteLine("DA is" + da);
        }
        public void GrossSalaray()
        {
            GrossSalary = Salaray + hra + ta + da;
            Console.WriteLine(GrossSalary);

        }
       /* public void PFCalculator()
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
        }*/
        public virtual void CalculateSalary()
        {
            pf = 0.1 * GrossSalary;
            Console.WriteLine(pf);
            tds = 0.18 * GrossSalary;
            Console.WriteLine(tds);
            NetSalaray = GrossSalary - (pf + tds);
            Console.WriteLine(NetSalaray);            
        }
        public void Display()
        {
            Console.WriteLine("Emp id is " + EmpNo);
            Console.WriteLine("Emp name is " + EmpName);
            Console.WriteLine("emp salaray is "+ Salaray);
            Console.WriteLine("emp gs is " + GrossSalary);
        }
    }

}
