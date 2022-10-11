// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

//Создание массива
int[,,] CreateMatrixRndInt(int rows, int columns, int cells, int min, int max)
{
    int[,,] matrix = new int[rows, columns, cells];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }

        }
    }
    return matrix;
}

//Печать массива
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],3}, ");
                else Console.Write($"{matrix[i, j, k],3} ");
                Console.Write($"({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}    

int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 10, 100);
PrintMatrix(matrix);