using System;

namespace PracticeTask10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите M не менее 5: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы построчно: ");
            int[,] array = new int[M, N];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int min = 32000;
            int num = 0;
            Console.WriteLine($"Введенный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int count = 1;
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],5}");
                    if (array[i, j] % 2 != 0)
                    {
                        count *= array[i, j];
                    }
                }
                Console.Write($"  {count}");
                if (min > count)
                {
                    min = count;
                    num = i;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Произведение элементов в строке {num}, минимально и равно {min}");
            for (int j = 0;j < array.GetLength(1); j++)
            {
                int temp = array[2,j];
                array[2,j] = array[4,j];
                array[4,j] = temp;
            }
            Console.WriteLine($"Сформированный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
        }

    }
}
