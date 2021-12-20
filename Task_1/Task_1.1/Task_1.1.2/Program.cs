using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string str = "";
            do
            {
                Console.WriteLine("Введите любое число: ");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out n));
            Console.Clear();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    if (j == i - 1)
                        Console.WriteLine("");
                }
            }

        }
    }
}