namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 3;
            int d = 5;
            for (int i = 1; i < 5; i++)
            {
                c += i; // Добавляем i к c на каждой итерации цикла
            }
            c += b;
            a = b + c;
            d = (a - b) + i; // i будет равно 5 после окончания цикла
            Console.WriteLine(d);
        }
    }
}
