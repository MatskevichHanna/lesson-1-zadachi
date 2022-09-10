Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstDigit = num / 10000 % 10;
int secondDigit = num / 1000 % 10;
int thirdDigit = num / 100 % 10;
int fourthDigit = num / 10 % 10;
int fiveDigit = num % 10;

if (num > 9999 && num < 100000)
{
    if (firstDigit == fiveDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Полиндром");
    }
    else
    {
        Console.WriteLine("Не полиндром");
    }
}
else
{
    Console.WriteLine("Введите другое число: ");
}