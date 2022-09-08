// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 99 && num1 < 1000)
{
    num1 = num1 % 10;
    Console.WriteLine($"Третья цифра {num1}");
}
else if (num1 > 1000)
{
    while (num1 > 1000)
    {
        num1 = num1 / 10;
    }
    num1 = num1 % 10;
    Console.WriteLine($"Третья цифра {num1}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}