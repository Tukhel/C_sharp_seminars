﻿// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = CreateArrayRndInt(5, -9, 10);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

int[] newArray = MultiPairsNumbers(array);
Console.Write("[");
PrintArray(newArray);
Console.Write("]");
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] MultiPairsNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;
    int[] newArr = new int[size];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArr[newArr.Length - 1] = arr[arr.Length / 2];
    return newArr;
}