// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое целое положительное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    if (numberM < numberN)
    {
        int sumNaturalElements = SumNaturalElementsIntervalMToN(numberM, numberN);
        Console.WriteLine($"M = {numberM}; N = {numberN} -> {sumNaturalElements}");
    }
    else
    {
        int sumNaturalElements = SumNaturalElementsIntervalMToN(numberN, numberM);
        Console.WriteLine($"M = {numberM}; N = {numberN} -> {sumNaturalElements}");
    }
}
else Console.WriteLine("Введены некорректные числа");

int SumNaturalElementsIntervalMToN(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num1 + SumNaturalElementsIntervalMToN(num1 + 1, num2);
}