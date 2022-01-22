using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Исходные данные для данной программы: 2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25\n\n");
            Console.Write("Введите число:\t");
            int nomber = Convert.ToInt32(Console.ReadLine()); ;
            var input_data = new int[] { 2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25 };
            int check = nomber;
            int n = input_data.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int summ = input_data[i] + input_data[j];
                    if (summ == nomber)
                    {
                        Console.WriteLine("Num 1 = {0}, Num 2 = {1}", input_data[i], input_data[j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
