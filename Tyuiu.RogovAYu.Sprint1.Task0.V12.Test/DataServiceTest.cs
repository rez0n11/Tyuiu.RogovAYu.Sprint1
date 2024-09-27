using Tyuiu.RogovAYu.Sprint1.Task0.V12.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task0_V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(res, 6);
        }
    }
}