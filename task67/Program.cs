// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write($"Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int num1)
{
    int sum = num1 % 10;
    if(num1 != 0)
    {
        sum += NaturalNumbers(num1/10);
    }
    return sum;
}

int UserNumber(int number, string messange)
{
    Console.Write(messange);
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write($"Ошибка ввода. \n{messange}");
    }
    return number;
}

int summa = 0;
summa = NaturalNumbers(num);
Console.WriteLine(summa);