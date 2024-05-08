using ObjectClassMethods;

namespace TestApp
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeManager manager = new EmployeeManager();
            var actual =  manager.Create(1, "anil", 1000);
            var expected = new Employee(1, "anil", 1000);
            Assert.AreEqual(expected, actual);
        }
    }
}