// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string range = Range(numberQuarter); ;
Console.WriteLine(range != null
                ? $"Данному типу четверти соответсвует диапазон -> {range}"
                : "Введена не корректная четверть");

string Range(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}