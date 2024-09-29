using Tyuiu.RogovAYu.Sprint1.Task4.V28.Lib;
namespace Tyuiu.RogovAYu.Sprint1.Task4.V28
{
    [TestClass]
    public class DataServiiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(ds.Calculate(0, 1), Math.Round(1 / 2.718281828,3));

        }
    }
}