using Tyuiu.MolchankinaAS.Sprint1.Task3.V10.Lib;
namespace Tyuiu.MolchankinaAS.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 23.4;
            var res = ds.NumberToMoney(x);
            double a = 40;
            Assert.AreEqual(x, res);
        }
    }
}