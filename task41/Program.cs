// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел которое будете вводить: ");
int size = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array)
{
    int i = 0;
    while (i < size)
    {
        Console.WriteLine($"Введите значение в {i + 1}-й элемент массива.");
        array[i] = int.Parse(Console.ReadLine());
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length - 1)
    {
        Console.Write($"{array[i]}, ");
        i++;
    }
    Console.Write($"{array[i]}]");
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] array = new int[Math.Abs(size)];
FillArray(array);
PrintArray(array);
int result = PositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0 = {result}");