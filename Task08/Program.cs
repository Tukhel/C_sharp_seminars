// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number <= 0)
{
    Console.WriteLine($"Число {number} не положительное");
}
else if (number == 1)
{
    Console.WriteLine("От 0 до 1 нет целых четных чисел");
}
else
{
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
