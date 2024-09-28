using Tyuiu.RogovAYu.Sprint1.Task7.V27.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(1.75, ds.Calculate(0, 0));
        }
     
    }
}