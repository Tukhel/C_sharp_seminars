// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1Line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1Line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2Line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2Line = Convert.ToInt32(Console.ReadLine());

double xCoordinate = FindPointX(b1Line, k1Line, b2Line, k2Line);
double yCoordinate = FindPointY(xCoordinate, b1Line, k1Line);

if(b1Line == b2Line && k1Line == k2Line) Console.WriteLine("Прямые совпадают");
else if(k1Line == k2Line) Console.WriteLine("Прямык параллельны");
else Console.WriteLine($"Точка пересечения прямых: ({xCoordinate}, {yCoordinate})");

double FindPointX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindPointY(double x, double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}