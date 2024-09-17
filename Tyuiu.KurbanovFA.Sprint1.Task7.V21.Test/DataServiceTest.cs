using Tyuiu.KurbanovFA.Sprint1.Task7.V21.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double x = 1, y = 5;
            double wait = 2.595;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}