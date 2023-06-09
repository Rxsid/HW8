// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void CountLinesMatrix(int[,] matrix)
{
    int n = 0;
    int temp = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           count += matrix[i, j];
             
        }
        if (count < temp)
        {
            temp = count;
            n = i + 1;
        }
        System.Console.Write($"Сумма строки номер {i+1} равна {count} " + "\t");
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов равен {n}");   
            
}


System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
CountLinesMatrix(matrix);