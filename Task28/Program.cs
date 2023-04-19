// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiplicationNumbers = MultiplicationNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplicationNumbers}");

int MultiplicationNumbers(int num)
{
    int multi = 1;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multi *= i;
        }
    }
    return multi;
}