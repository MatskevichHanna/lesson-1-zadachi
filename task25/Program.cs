// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

double Power(int num, int deg)
{
    double power = 1;
    if (deg >= 0)
        for (int i = 0; deg > i; i++)
        {
            power = power * num;
        }
    else
        for (int i = 0; deg < i; i--)
        {
            power = power / num;
        }
    return power;
}
double result = Power(number, degree);
Console.WriteLine($"Число {number} в степени {degree} равно {result}");