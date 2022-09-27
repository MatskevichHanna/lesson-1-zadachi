//  Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("|");
    }
}

// int[,] IntMatrixLinesChanger(int[,] matrix)
// {
//     int temp = default;
//     linesCount = matrix.GetLength(0);
//     columnsCount = matrix.GetLength(1);
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i == 0)
//             {
//                 temp = matrix[i, j];
//                 matrix[i, j] = matrix[linesCount - 1, j];
//                 matrix[linesCount - 1, j] = temp;
//             } 
//         }
//     }
//     return matrix;
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(array2D);
// Console.WriteLine();
// IntMatrixLinesChanger(array2D);
// PrintMatrix(array2D);

void ChangePlase(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
ChangePlase(array2D);
PrintMatrix(array2D);