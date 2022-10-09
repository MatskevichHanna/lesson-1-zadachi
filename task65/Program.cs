// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.Clear();
// Console.Write($"Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{numM} ");
// NaturalNumbers(numM, numN);

// void NaturalNumbers(int numberM, int numberN)
// {
//     if (numberN == numberM) return;
//     NaturalNumbers(numberM, numberN - 1);
//     Console.Write($"{numberN} ");
// }
//__________________________________________________________
// Console.Clear();
// Console.Write("Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int tempBig = default;
// int tempSmall = default;
// if (numM > numN)
// {
//     tempBig = numM;
//     tempSmall = numN;
// }
// else
// {
//     tempBig = numN;
//     tempSmall = numM;
// }

// Console.Write($"M = {tempSmall}; N = {tempBig} -> ");
// NaturalNumbers(tempSmall, tempBig);
// Console.WriteLine();

// void NaturalNumbers(int numberM, int numberN)
// {
//     if (numberN < numberM) return;
//     NaturalNumbers(numberM, numberN - 1);
//     Console.Write($"{numberN} ");
// }
//__________________________________________________
Console.Clear();
Console.Write($"Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int numberM, int numberN)
{
    if (numberM == numberN) Console.Write(numberN);
    if (numberM > numberN)
    {
        Console.Write($"{numberM} ");
        NaturalNumbers(numberM - 1, numberN);
    }
    if (numberM < numberN)
    {
        Console.Write($"{numberM} ");
        NaturalNumbers(numberM + 1, numberN);
    }
}
NaturalNumbers(numM, numN);