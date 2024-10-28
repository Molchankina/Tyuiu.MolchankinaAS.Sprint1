using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MolchankinaAS.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12);
            //(Math.Exp(x) - (Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 3)) + 12 * x * y - 3 * Math.Pow(x, 2)) / (Math.Cos((Math.Pow(x, 3) + 3)) + 18 * y - 1));

            return Math.Round(res, 3);
        }
    }
}