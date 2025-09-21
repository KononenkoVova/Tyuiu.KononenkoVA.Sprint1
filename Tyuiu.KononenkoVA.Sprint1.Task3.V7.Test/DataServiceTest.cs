using Tyuiu.KononenkoVA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 2.134;
            var res = Math.Round(ds.VerstsToKilometers(x),3);
            Assert.AreEqual(wait, res);
        }
    }
}
