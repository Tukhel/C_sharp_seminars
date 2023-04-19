﻿// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int quantlyDigit = QuantlyDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {quantlyDigit}");

int QuantlyDigit(int num)
{
    int res = 0;
    while (num != 0)
    {
        num /= 10;
        res++;
    }
    return res;
}