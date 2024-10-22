using System.Globalization;
using Tyuiu.MolchankinaAS.Sprint1.Task3.V10.Lib;
namespace Tyuiu.MolchankinaAS.Sprint1.Task3.V10;

class Program
{
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Молчанкина А. П. | СМАРТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Известна длина стороны куба. Вычислить площадь боковой поверхности*");
        Console.WriteLine("* куба.                                                                   *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Молчанкина Ангелина Павловна | СМАРТб-24-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры дробное  *");
        Console.WriteLine("* число в денежный формат.                                                *");
        Console.WriteLine("*                                                                         *");
        //Console.WriteLine(Math.Floor(23.6));
        //double x;
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine(x + " руб. " + "- " + "это " + Math.Floor(x) + "руб. " + Math.Round((x - Math.Floor(x))*100) + " коп.");
        //(x + " руб. " + "- " + "это " + Math.Floor(x) + "руб. " + Math.Round((x - Math.Floor(x)) * 100) + " коп.");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(x + " руб.");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(x + " руб. " + "- " + "это " + Math.Floor(x) + "руб. " + Math.Round((x - Math.Floor(x)) * 100) + " коп.");
        Console.ReadLine();
    }
}
