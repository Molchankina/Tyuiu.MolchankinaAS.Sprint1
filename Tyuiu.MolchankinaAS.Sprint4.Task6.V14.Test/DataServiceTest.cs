using Tyuiu.MolchankinaAS.Sprint4.Task6.V14.Lib;
namespace Tyuiu.MolchankinaAS.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] months = { "������", "�������", "����", "������", "���", "����", "����" };
            string[] res = ds.Calculate(months);
            string[] wait = { "������", "�������", "����", "������", "����", "����" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}