﻿// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);

int SumDigit(int num)
{
    int result = 0;

    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }

    return result;
}