using Tyuiu.KononenkoVA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KononenkoVA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 15;
            double y1 = 4;
            double x2 = 8;
            double y2 = 9;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int wait = 8;
            Assert.AreEqual(wait, res);

        }
    }
}
