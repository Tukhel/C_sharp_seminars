// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = CreateArrayRndInt(6, 1, 20);
PrintArray(array);
Console.WriteLine();

int[] newArray = CopyArray(array);
PrintArray(newArray);

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

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}