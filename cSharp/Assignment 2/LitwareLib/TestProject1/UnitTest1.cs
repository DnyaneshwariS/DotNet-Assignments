using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEmp.test
{
    [TestClass]
    [TestCategory("CheckNotNull")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var emp = new Empl();
            Assert.IsNull(emp.EmpNo);
        }
    }
}
