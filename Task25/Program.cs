// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число которое нужно возвести в степень: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральную степень в которую нужно возвести: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 < 0 || number2 % 1 != 0) Console.WriteLine("Введена некорректная степень");
else 
{
    double pow = Pow(number1, number2);
    Console.WriteLine(pow);
}     

double Pow(double num1, int num2)
{
    double result = 1;

    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}