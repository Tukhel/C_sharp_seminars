// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.Write("Введите первое целое положительное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbersMToN(numberM, numberN);

void NaturalNumbersMToN(int numM, int numN)
{
    if (numM < numN)
    {   
        Console.Write($"{numM} ");
        NaturalNumbersMToN(numM + 1, numN);
        
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMToN(numM - 1, numN);
    }
    else Console.Write(numM);
   }