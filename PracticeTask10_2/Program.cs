using System;

namespace PracticeTask10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы построчно: ");
            int[,] array = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Введенный массив: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
