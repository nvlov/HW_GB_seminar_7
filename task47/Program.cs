/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using System;

class Program
{
    static void Main()
    {
        int m = 3; // начальное количество строк
        int n = 4; // начальное количество столбцов

        Console.Clear();
		Console.Write("Введите количество строк: ");
        m = int.Parse(Console.ReadLine()!); // изменяем количество строк

        Console.Write("Введите количество столбцов: ");
        n = int.Parse(Console.ReadLine()!); // изменяем количество столбцов

        double[,] randomArray = CreateRandomArray(m, n);
        PrintArray(randomArray);
    }

    static double[,] CreateRandomArray(int m, int n)
    {
        Random random = new Random();
        double[,] array = new double[m, n];
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double randomNumber = Math.Round((random.NextDouble() * 200) - 100, 1); // случайное число с одним знаком после запятой
                array[i, j] = randomNumber;
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
                Console.Write(array[i, j].ToString("0.0") + "	");
            }
            Console.WriteLine();
        }
    }
}

