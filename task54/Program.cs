﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        System.Console.Write($"{matrix[i, j]} " + "\t");
        }
    System.Console.WriteLine();
    }
}

void SortLinesMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            

            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
            int maxPosition = j;
            {
            if(matrix[i, k] > matrix[i, maxPosition]) maxPosition = k;
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, maxPosition];
            matrix[i, maxPosition] = temporary;
            }
       
            
        }
            
    }
}


System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
SortLinesMatrix(matrix);
PrintMatrix(matrix);