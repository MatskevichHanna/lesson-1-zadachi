// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write($"Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    if (numM > numN) return numM + NaturalNumbers(numN, numM - 1);
    else return numN + NaturalNumbers(numN - 1, numM);
}

int summa = NaturalNumbers(numberM, numberN);
Console.WriteLine($"{summa}");
