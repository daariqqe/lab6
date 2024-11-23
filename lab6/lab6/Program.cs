using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {   
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            {
                //task 1 
                Console.WriteLine("Завдання 1");
                Console.Write("Введіть значення а: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введіть значення b: ");
                double b = double.Parse(Console.ReadLine());
                double z = Min(a, 2 * b) + Min(2 * a - b, b);
                Console.WriteLine($"Результат: z = {z}");
                double Min(double x, double y)
                {
                    return Math.Min(x, y);
                }
            }
            {
                //task 2
                Console.WriteLine("\nЗавдання 2");
                Console.Write("Введіть значення x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть значення t: ");
                double t = Convert.ToDouble(Console.ReadLine());
                double a = A(x);
                double b = B(x, t);
                double y = Math.Pow(Math.Abs(a - b), 1.0 / 3.0);
                Console.WriteLine($"Результат: y = {y}");
                double A(double x)
                {
                    return Math.Log10(x);
                }
                double B(double x, double t)
                {
                    return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(t, 2));
                }
            }
            {
                //task 3 
                Console.WriteLine("\nЗавдання 3");
                int[,] matrix = new int[4, 6];
                GenerateMatrix(matrix);
                Console.WriteLine("Початкова матриця:");
                WriteMatrix(matrix);
                var (rowIndex, maxSum) = FindRowWithMaxSum(matrix);
                Console.WriteLine($"Рядок з максимальною сумою: {rowIndex} (починаючи з 0)");
                Console.WriteLine($"Максимальна сума: {maxSum}");
                static void GenerateMatrix(int[,] matrix)
                {
                    Random random = new Random();
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = random.Next(0, 100);
                        }
                    }
                }
                static void WriteMatrix(int[,] matrix)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i, j],4} ");
                        }
                        Console.WriteLine();
                    }
                }
                static (int, int) FindRowWithMaxSum(int[,] matrix)
                {
                    int maxSum = int.MinValue;
                    int maxRowIndex = -1;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        int currentRowSum = 0;
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            currentRowSum += matrix[i, j];
                        }

                        if (currentRowSum > maxSum)
                        {
                            maxSum = currentRowSum;
                            maxRowIndex = i;
                        }
                    }
                    return (maxRowIndex, maxSum);
                }
            }
            {
                // task 4 
                Console.WriteLine("\nЗавдання 4");
                Console.Write("Введіть натуральне число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int digitalRoot = FindDigitalRoot(number);
                Console.WriteLine($"Цифровий корінь числа {number}: {digitalRoot}");
                static int FindDigitalRoot(int n)
                {
                    if (n < 10)
                    {
                        return n;
                    }
                    int sum = 0;
                    while (n > 0)
                    {
                        sum += n % 10;
                        n /= 10;
                    }
                    return FindDigitalRoot(sum);
                }
            }
            Console.ReadKey();
        }
    }
}


