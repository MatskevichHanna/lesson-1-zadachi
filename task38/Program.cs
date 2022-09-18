// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    int i = 0;
    int j = -1;
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        i += 1;
        j -= 1;
    }
    return Math.Round((max - min), 1);
}

double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArray(arr);
double result = DifferenceMaxMin(arr);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result}");