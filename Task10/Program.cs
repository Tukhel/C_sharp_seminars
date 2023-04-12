// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное, целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int res = SecondDigit(number);
    Console.WriteLine($"Второе число -> {res}");
}
else if (number < -99 && number > -1000)
{
    int res = -SecondDigit(number);
    Console.WriteLine($"Второе число -> {res}");
}
{
    Console.WriteLine("Вы ввели не верное число");
}

int SecondDigit(int num)
{
    int TwoLastDigit = num % 100;
    int result = TwoLastDigit / 10;
    return result;
}