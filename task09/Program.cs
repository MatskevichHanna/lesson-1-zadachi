// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// int firstDigit = number / 10;  //7
// int secondDigit = number % 10;  //8
// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

// if(firstDigit == secondDigit) Console.WriteLine($"Цифры равны");
// else
// {
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;
//     Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");
// }
int number = new Random().Next(10, 100);

int MaxDigit(int num)
{
    int firstDigit = num / 10;  //7
    int secondDigit = num % 10;  //8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");