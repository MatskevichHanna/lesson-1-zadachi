Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sqeare = num2 * num2;
if (sqeare == num1)
{
    Console.Write($"Число {num1} является квадратом {num2}");
} 
else
{
    Console.Write($"Число {num1} не является квадратом {num2}");
}