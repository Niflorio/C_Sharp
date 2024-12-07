using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashca1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите положительное число: ");
            int maxNumber;

            while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber < 2)
            {
                Console.WriteLine("Ошибка: введите целое положительное число (не меньше 2).");
            }

            Console.WriteLine($"Простые числа не превышающие {maxNumber}:");
            for (int i = 2; i <= maxNumber; i++)
            {
                if (IsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static bool IsPrimo(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
