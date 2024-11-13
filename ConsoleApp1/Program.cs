﻿
double start = 7, end = 9, step = 1;
for (double x = start; x <= end; x+=step)
{
    double result = 2 * x + 3 * Math.Pow(x,2) - 34;
    if (double.IsInfinity(result) || double.IsNaN(result))
    {
        result = 0;
    }
    result = Math.Round(result, 2);
    Console.WriteLine(result);
}
