// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

//Создание массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//Печать массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

//Нахождение суммы элементов в каждой строке
int[] SumSearch(int[,] matrix)
{
    int[] SumResult = new int[matrix.GetLength(1)];     
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        SumResult[i] = summ;
    }
    return SumResult;
}

//Нахождение строки с наименьшей суммой
void MinSumElemRow(int[] array)
{
    int min = array[0];
    int indexmin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexmin = i;
        }
    }
    Console.WriteLine($"Наименьшеая сумма элементов в строке №{indexmin + 1}");
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = SumSearch(matrix);
MinSumElemRow(array);