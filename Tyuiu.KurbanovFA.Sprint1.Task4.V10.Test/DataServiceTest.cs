using Tyuiu.KurbanovFA.Sprint1.Task4.V10.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double a = 1;
            double wait = 2.175;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}