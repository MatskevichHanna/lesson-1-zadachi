// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);

int MaxDigit(int num)
{
    int firstDigit = num / 10 % 10;
    return firstDigit;
}

int result = MaxDigit(number);
Console.WriteLine($"{number} -> {result}");
