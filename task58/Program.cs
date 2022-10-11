// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// Создание второго массива и перемножение его с первым
int[,] MultiplicationMatrix(int[,] first, int[,] second)
{
    int[,] multiplication = new int[second.GetLength(0), second.GetLength(1)];
    if (first.GetLength(1) != first.GetLength(0))
    {
        Console.WriteLine($"Произвести расчёт невозможно!");
    }
    else
    {
        for (int i = 0; i < first.GetLength(0); i++)
        {
            for (int j = 0; j < second.GetLength(1); j++)
            {
                for (int k = 0; k < second.GetLength(0); k++)
                {
                    multiplication[i, j] += first[i, k] * second[k, j];
                }
            }
        }
    }
    return multiplication;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] result = MultiplicationMatrix(matrix1, matrix2);
PrintMatrix(result);