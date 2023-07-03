/*Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
	    Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение: ");
        int minValue = int.Parse(Console.ReadLine());

        Console.Write("Введите максимальное значение: ");
        int maxValue = int.Parse(Console.ReadLine());
        int[,] array = CreateRandomArray(m, n, minValue, maxValue);

        Console.WriteLine("Исходный массив:	");
        PrintArray(array);

        double[] columnAverages = CalculateColumnAverages(array);

        Console.WriteLine("Среднее арифметическое в каждом столбце: ");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Столбец {0}: {1}", j + 1, columnAverages[j]);
        }
    }

    static int[,] CreateRandomArray(int m, int n, int minValue, int maxValue)
    {
        Random random = new Random();
        int[,] array = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(minValue, maxValue + 1);
            }
        }

        return array;
    }
    
    static void PrintArray(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    static double[] CalculateColumnAverages(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        double[] columnAverages = new double[n];

        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double)sum / m;
        }
        return columnAverages;
    }
}

