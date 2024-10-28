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
            double number = 23.6;
            string expectedResult = "23,6 руб. Ч это 23 руб. 60 коп.";
            string actualResult = ds.NumberToMoney(number);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}