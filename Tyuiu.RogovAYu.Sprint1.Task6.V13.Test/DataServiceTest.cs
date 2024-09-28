using Tyuiu.RogovAYu.Sprint1.Task6.V13.Lib;
namespace Tyuiu.RogovAYu.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckWordsAlphabet("abc"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(false, dataService.CheckWordsAlphabet("acb"));

        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckWordsAlphabet("bz"));
        }
    }
}