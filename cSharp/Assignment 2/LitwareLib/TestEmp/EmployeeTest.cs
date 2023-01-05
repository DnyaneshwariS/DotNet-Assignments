using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEmp
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var emp = new Emplyoee();
            Assert.IsNull(emp.HRACalculate());
        }
    }
}
