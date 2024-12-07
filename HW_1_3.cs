using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashca1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Коэффициент a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Коэффициент b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Коэффициент c: ");
            double c = double.Parse(Console.ReadLine());

            SolveEquation(a, b, c);

            Console.ReadKey();
        }

        static void SolveEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Уравнение имеет бесконечно много решений (0 = 0).");
                    }
                    else
                    {
                        Console.WriteLine("Нет корней.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Уравнение имеет лишь один корень: x = {x}");
                }
            }
            else
            {
                if ((Math.Pow(b, 2) - 4 * c * a) < 0)
                {
                    Console.WriteLine("Нет решений.");
                }
                else
                {
                    double discriminant = b * b - 4 * a * c;
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"Уравнение имеет два различных корня: x1 = {x1}, x2 = {x2}");
                }
            }

        }
    }
}
