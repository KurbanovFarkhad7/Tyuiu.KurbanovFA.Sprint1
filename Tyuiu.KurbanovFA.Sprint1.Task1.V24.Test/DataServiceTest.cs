using Tyuiu.KurbanovFA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}