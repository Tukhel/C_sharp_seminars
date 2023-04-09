// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int numberDayWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayWeek == 1)
{
    Console.Write($"{numberDayWeek} это понедельник");
}
else if (numberDayWeek == 2)
{
    Console.Write($"{numberDayWeek} это вторник");
}
else if (numberDayWeek == 3)
{
    Console.Write($"{numberDayWeek} это среда");
}
else if (numberDayWeek == 4)
{
    Console.Write($"{numberDayWeek} это четверг");
}
else if (numberDayWeek == 5)
{
    Console.Write($"{numberDayWeek} это пятница");
}
else if (numberDayWeek == 6)
{
    Console.Write($"{numberDayWeek} это суббота");
}
else if (numberDayWeek == 7)
{
    Console.Write($"{numberDayWeek} это воскресенье");
}
else
{
    Console.Write("Такого дня недели нет");
}