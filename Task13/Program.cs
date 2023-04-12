// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int digit = 0;

if (number > 999 || number < -999)
{
    while (number > 999 || number < -999)
    {
        number = number / 10;
    }
    digit = ThirdDigit(number);
    Console.WriteLine($"Третье число -> {digit}");
}
else if (number < 100 && number > -100)
{
    Console.WriteLine($"Нет третьего числа");
}
else
{
    digit = ThirdDigit(number);
    Console.WriteLine($"Третье число -> {digit}");
}

int ThirdDigit(int num)
{
    int result = num % 10;
    return result;
}