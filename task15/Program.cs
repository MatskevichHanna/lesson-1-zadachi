// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number < 8)
{
    Console.WriteLine($"Правда, этот день выходной");
}

else if (number > 0 && number < 6)
{
    Console.WriteLine($"Ложь, этот день не выходной");
}

else
{
    Console.WriteLine($"Введите другое число");
}

// bool week(int num)
// {
//     return (num == 6 || num == 7);
// }

// bool result = week(number);

// if(result) Console.WriteLine($"Правда");
// else Console.WriteLine($"Ложь");
