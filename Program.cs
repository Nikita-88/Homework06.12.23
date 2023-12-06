//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
        int[,] twoDArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.Write("Введите номер строки: ");
        if (int.TryParse(Console.ReadLine(), out int row) && row >= 0 && row < twoDArray.GetLength(0))
        {
            Console.Write("Введите номер столбца: ");
            if (int.TryParse(Console.ReadLine(), out int col) && col >= 0 && col < twoDArray.GetLength(1))
            {
                int element = GetArrayElement(twoDArray, row, col);
                if (element != -1)
                {
                    Console.WriteLine($"Значение элемента [{row},{col}] равно: {element}");
                }
                else
                {
                    Console.WriteLine($"Элемента с позицией [{row},{col}] не существует в массиве.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод для номера столбца.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для номера строки.");
        }
    }

    static int GetArrayElement(int[,] array, int row, int col)
    {
        if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
        {
            return array[row, col];
        }

        return -1;
    }
}

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;

class Program
{
    static void Main()
    {
        int[,] twoDArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(twoDArray);

        SwapRows(twoDArray, 0, twoDArray.GetLength(0) - 1);

        Console.WriteLine("\n Массив после обмена первой и последней строк:");
        PrintArray(twoDArray);
    }

    static void SwapRows(int[,] array, int row1, int row2)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            (array[row1, i], array[row2, i]) = (array[row2, i], array[row1, i]);
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



using System;

class Program
{
    static void Main()
    {
        int[,] rectangularArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(rectangularArray);

        int minSumRowIndex = FindRowWithMinSum(rectangularArray);
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}"); // +1, так как индексы начинаются с 0
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
