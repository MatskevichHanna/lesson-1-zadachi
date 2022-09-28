// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

// Первый вариант решения
// Console.Clear();
// Random randomizer = new Random();
// int randomRows = randomizer.Next(4, 7),
// randomColumns = randomizer.Next(4, 7);

// int[,] array2D = CreateMatrixRndInt(randomRows, randomColumns, 10, 20);
// PrintMatrix(array2D);

// Console.WriteLine("-------------------------------------------------------------");
// int[,] IntMatrixLinesToColumnsChanger(int[,] matrix)
// {
//     int temp = default,
//     linesCount = matrix.GetLength(0),
//     columnsCount = matrix.GetLength(1);
//     int[,] newmatrix = new int[columnsCount, linesCount];
//     if (linesCount == columnsCount)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 newmatrix[j, i] = matrix[i, j];
//             }
//         }
//     }
//     else Console.WriteLine("Это сделать невозможно");
//     return newmatrix;
// }
// int[,] result = IntMatrixLinesToColumnsChanger(array2D);
// PrintMatrix(result);

// Второй вариант решения
int[,] ChangePlase(int[,] arr)
{
    int[,] arrResult = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            arrResult[i, j] = arr[j, i];
        }
    }
    return arrResult;
}

bool CheckSq(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();

if(CheckSq(matrix))
{
    int[,] array = ChangePlase(matrix);
    PrintMatrix(array);
}
else Console.WriteLine("Невозможно заменить");