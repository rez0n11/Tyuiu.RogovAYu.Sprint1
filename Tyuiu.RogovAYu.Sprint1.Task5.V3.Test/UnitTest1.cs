using Tyuiu.RogovAYu.Sprint1.Task5.V3.Lib;
namespace Tyuiu.RogovAYu.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.Calculate(13048));
        }
    }
}