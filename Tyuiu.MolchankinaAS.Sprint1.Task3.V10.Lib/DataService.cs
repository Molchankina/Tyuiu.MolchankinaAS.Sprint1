using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MolchankinaAS.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int rubles = (int)number;
            int kopeks = (int)Math.Round((number - rubles) * 100);

            return $"{number:F1} руб. - это {rubles} руб. {kopeks} коп.";
        }
    }
}