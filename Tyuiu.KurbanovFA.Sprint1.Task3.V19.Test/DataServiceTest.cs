using Tyuiu.KurbanovFA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double x1 = 3, y1 = 3, x2 = 8, y2 = 8;
            var res = ds.ElephCanMove(x1, x2, y1, y2); 
            Assert.IsFalse(res);
        }
    }
}