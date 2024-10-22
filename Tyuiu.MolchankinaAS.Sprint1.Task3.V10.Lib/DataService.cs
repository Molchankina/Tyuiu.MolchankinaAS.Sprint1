using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MolchankinaAS.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            double r;
            r = Math.Floor(number);
            double k;
            k = (number - Math.Floor(number));
            return r + k;
        }
    }
}