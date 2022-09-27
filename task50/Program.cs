//  Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();
Console.WriteLine("Ввведите индекс элемента в строке: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите индекс элемента в столбце: ");
int j = Convert.ToInt32(Console.ReadLine());


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

void ValueElementPosition(int[,] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемен находящихся на позиции {i},{j} равен {matrix[i, j]}");
    } 
    else Console.WriteLine($"Такого элемента нет");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
ValueElementPosition(array2D);