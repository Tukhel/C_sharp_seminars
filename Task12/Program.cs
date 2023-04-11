// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Remainder(firstNumber, secondNumber);

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {result}");

int Remainder(int first, int second)
{
    return first % second;
}