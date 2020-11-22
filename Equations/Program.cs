using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo reset;
            do
            {
                Console.Clear();

                Console.WriteLine("Solving a quadratic equation");
                Console.WriteLine("Formula: ax^2 + bx + c = 0");
                Console.WriteLine();

                bool resultA;
                int a;
                do
                {
                    Console.Write("Введите a = ");
                    string inputA = Console.ReadLine();

                    resultA = int.TryParse(inputA, out a);
                    while (!resultA)
                    {
                        Console.WriteLine("Please enter a number");
                        break;
                    }
                } while (!resultA);
                Console.WriteLine();

                bool resultB;
                int b;
                do
                {
                    Console.Write("Enter b = ");
                    string inputeB = Console.ReadLine();

                    resultB = int.TryParse(inputeB, out b);
                    while (!resultB)
                    {
                        Console.WriteLine("Please enter b number");
                        break;
                    }
                } while (!resultB);
                Console.WriteLine();

                bool resultC;
                int c;
                do
                {
                    Console.Write("Введите c = ");
                    string inputeC = Console.ReadLine();

                    resultC = int.TryParse(inputeC, out c);
                    while (!resultC)
                    {
                        Console.WriteLine("Please enter c number");
                        break;
                    }
                } while (!resultC);
                Console.WriteLine();

                Console.WriteLine("The resulting formula: {0}x^2 + ({1}x) + ({2}) = 0", a, b, c);
                Console.WriteLine();

                Console.WriteLine("D = b^2 - 4ac");
                Console.WriteLine("D = {0}^2 - 4 * {1} * {2}", b, a, c);
                Console.WriteLine();

                int D = (b * b) - (4 * a * c);

                Console.WriteLine("D = {0}", D);
                Console.WriteLine();

                float x1 = 0;
                float x2 = 0;

                if (D < 0)
                {
                    Console.WriteLine("x has no roots");
                }
                else if (D == 0)
                {
                    float x0 = (b + Convert.ToSingle(Math.Sqrt(D))) / (2 * a);
                    Console.Write("x has one root: {0}");

                }
                else if (D > 0)
                {

                    x1 = (-b + Convert.ToSingle(Math.Sqrt(D))) / (2 * a);
                    Console.WriteLine($"x1 = {x1}");
                    x2 = (-b - Convert.ToSingle(Math.Sqrt(D))) / (2 * a);
                    Console.WriteLine($"x2 = {x2}");
                }
                Console.WriteLine();

                Console.WriteLine("Factorization");
                Console.WriteLine("Formula: ax^2 + bx + c = а(x - x1)(x - x2)");
                Console.WriteLine();

                Console.WriteLine($"Decision: {a}x^2 + ({b}x) + ({c}) = {a}(x - ({x1}))(x - ({x2}))");


                Console.WriteLine("Start over? (Press any key to continue or Escape to end)");
                reset = Console.ReadKey(true);
               
            } while (reset.Key != ConsoleKey.Escape);
        }
    }
}
