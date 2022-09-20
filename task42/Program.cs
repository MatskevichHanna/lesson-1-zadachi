// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
int num = default;
Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.Write("Ошибка ввода. Введите целое число: ");
}


int ConvertToBinary(int number)
{
    int result = default;
    int count = 1;
    while (number != 0)
    {
        result += (number % 2) * count;
        number = number / 2;
        count *= 10;
    }
    return result;
}

Console.Write(ConvertToBinary(num));
