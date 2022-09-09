//  Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc)
{
    if (x == 1) return "x>0, y>0";
    if (x == 2) return "x<0, y>0";
    if (x == 3) return "x<0, y<0";
    if (x == 4) return "x>0, y<0";
    return "Введите число от 1 до 4: ";
}
string result = Quarter(x);
Console.WriteLine(result);