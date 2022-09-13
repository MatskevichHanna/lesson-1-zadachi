// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumbers(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int sum = 1;
        for (int i = 1; i <= num; i++)
        {
            sum *= i;
        }
        return sum;
    }
    return 1;
}

int multNumbers = MultNumbers(number);
Console.WriteLine($"Факториал числа {number}! = {multNumbers}");