using Tyuiu.KurbanovFA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double f = 10;
            int wait = 1;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}