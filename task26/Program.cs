//  Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
    //     int i;
    //     for (i = 1; i <= num; i ++)
    //     {
    //         num = num/10;
    //     }
    //     return i;
    // }
    // int result = Count(number);
    // Console.WriteLine(result);
    if (num != 0)
    {
        if (num < 0) num = -num;
        int count = default;
        while (num > 0)
        {
            num = num / 10;
            count++;
        }
        return count;
    }
    return 1;
}
int result = Count(number);
Console.WriteLine(result);