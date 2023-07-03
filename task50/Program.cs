/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = CreateRandomArray(m, n);
        PrintArray(array);

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        int value = GetValue(array, row, column);

        if (value != -1)
        {
            Console.WriteLine("Значение элемента: " + value);
        }
        else
        {
            Console.WriteLine("Такого элемента нет");
        }
    }

    static int[,] CreateRandomArray(int m, int n)
    {
        Random random = new Random();
        int[,] array = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(100);
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
                Console.Write(array[i, j] + "	");
            }
            Console.WriteLine();
        }
    }

    static int GetValue(int[,] array, int row, int column)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            return array[row, column];
        }

        return -1;
    }
}
