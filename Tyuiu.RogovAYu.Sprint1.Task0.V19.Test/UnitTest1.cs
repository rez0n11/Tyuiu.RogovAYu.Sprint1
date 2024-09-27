using Tyuiu.RogovAYu.Sprint1.Task1.V19.Lib;
namespace Tyuiu.RogovAYu.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(10.5,dataService.Calculate(1,2));
        }
    }
}