using Tyuiu.KononenkoVA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "Привет";
            string b = "пока";
            bool res1 = ds.CheckLowerCaseRusLetters(a);
            bool res2 = ds.CheckLowerCaseRusLetters(b);
            bool wait1 = false;
            bool wait2 = true;
            Assert.AreEqual(res1,wait1);
            Assert.AreEqual(res2, wait2);

        }
    }
}
