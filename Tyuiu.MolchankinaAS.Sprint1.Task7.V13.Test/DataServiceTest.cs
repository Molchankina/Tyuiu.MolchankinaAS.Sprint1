using Tyuiu.MolchankinaAS.Sprint1.Task7.V13.Lib;
namespace Tyuiu.MolchankinaAS.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 1.636;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}