using Tyuiu.KurbanovFA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 100;
            var res = ds.ConvertMToKm(value);
            Assert.AreEqual(0.1, res);
        }
    }
}