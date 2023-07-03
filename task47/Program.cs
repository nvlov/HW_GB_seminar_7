/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine()!);

        double[,] array = CreateRandomArray(m, n, -100, 100); // Здесь указывается диапазон значений в массиве
        PrintArray(array);        
    }

    static double[,] CreateRandomArray(int m, int n, double minValue, double maxValue)
    {
        Random random = new Random();
        double[,] array = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * (maxValue - minValue) + minValue; 
            }
        }

        return array;
    }

    static void PrintArray(double[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "   "); 
            }
            Console.WriteLine();
        }
    }
}
