using Tyuiu.KurbanovFA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            string value = "�������� ���� ���������";
            string wait = "�������� ���������";
            var res = ds.CheckDoubleN(value);
            Assert.AreEqual(wait, res);
        }
    }
}