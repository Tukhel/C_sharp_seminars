// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());

int[] arrayUserNumbers = ArrayUserNumbers(amount);

int result = PositiveNumber(arrayUserNumbers);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел = {result}");


int[] ArrayUserNumbers(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}
