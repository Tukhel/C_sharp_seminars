// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek > 0 && dayWeek < 8)
{
    bool result = Weekend(dayWeek);
    Console.WriteLine(result ? "Да" : "Нет");
}
else Console.WriteLine("Такого дня недели нет");

bool Weekend(int day)
{
    return day == 6 || day == 7;
}