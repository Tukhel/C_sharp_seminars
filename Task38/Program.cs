// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(6, 1, 100);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

double diffMaxMin = DiffMaxMin(FindMaxNumbersArray(array), FindMinNumbersArray(array));
double roundDiffMaxMin = Math.Round(diffMaxMin, 1);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {roundDiffMaxMin}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round} | ");
        else Console.Write($"{round}");
    }
}

double FindMaxNumbersArray(double[] arr)
{
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMinNumbersArray(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double DiffMaxMin(double numMax, double numMin)
{
    double res = numMax - numMin;
    return res;
}