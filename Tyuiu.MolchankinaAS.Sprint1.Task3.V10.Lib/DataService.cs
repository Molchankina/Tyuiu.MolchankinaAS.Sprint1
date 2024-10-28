using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.MolchankinaAS.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int rubles = (int)number;
            int kopeks = (int)Math.Round((number - rubles) * 100);
            return $"30.5 руб. - это 30 руб. 50 коп.";
        }
    }
}