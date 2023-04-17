﻿// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SquareTable(number);

void SquareTable(int num)
{
    int count = 0;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3}  {count * count, 4}");
        count++;
    }
}