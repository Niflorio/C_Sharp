using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите число: ");
        ulong n;

        while (!ulong.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Ошибка: введите неотрицательное целое число.");
        }

        Console.Write("Выберите метод (1 - факториал, 2 - фибоначчи): ");
        int choice = int.Parse(Console.ReadLine());

        Stopwatch stopwatch = new Stopwatch();
        

        if (choice == 1)
        {
            
            stopwatch.Start();
            ulong factorialRec = FactRecurs(n);
            stopwatch.Stop();
            long timefactRec = stopwatch.ElapsedTicks;
            Console.WriteLine($"Рекурсивно: {n}! = {factorialRec}, время выполнения: {timefactRec} тактов");

            stopwatch.Restart();
            ulong factorialIter = FactIterat(n);
            stopwatch.Stop();
            long timefactIt = stopwatch.ElapsedTicks;
            Console.WriteLine($"Итеративно: {n}! = {factorialIter}, время выполнения: {timefactIt} тактов");

            Console.WriteLine($"разница в скорости: {timefactIt - timefactRec}");

        }
        else if (choice == 2)
        {

            stopwatch.Start();
            ulong fibonacciRec = FibRecurs(n);
            stopwatch.Stop();
            long timefibRec = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Рекурсивно: F({n}) = {fibonacciRec}, время выполнения: {timefibRec} тактов");

            stopwatch.Restart();
            ulong fibonacciIter = FibIterat(n);
            stopwatch.Stop();
            long timefibIt = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Итеративно: F({n}) = {fibonacciIter}, время выполнения: {timefibIt} тактов");

            Console.WriteLine($"разница в скорости: {timefibIt - timefibRec}");
        }


        Console.ReadKey();
        //рекурсивный метод начинает заметно отставать по производительности при n >= 20-25
    }


    static ulong FactRecurs(ulong n)
    {
        if (n == 0) return 1;
        return n * FactRecurs(n - 1);
    }


    static ulong FactIterat(ulong n)
    {
        ulong result = 1;
        for (uint i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }


    static ulong FibRecurs(ulong n)
    {
        if (n <= 1) return n;
        return FibRecurs(n - 1) + FibRecurs(n - 2);
    }


    static ulong FibIterat(ulong n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        ulong a = 0, b = 1, result = 0;
        for (uint i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }
}
