// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первую сторону треугольника: ");
int firstSideTriangle = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int secondSideTriangle = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int thirdSideTriangle = Convert.ToInt32(Console.ReadLine());

bool existTriangle = IsExistTriangle(firstSideTriangle, secondSideTriangle, thirdSideTriangle);
Console.WriteLine(existTriangle ? "Да" : "Нет");

bool IsExistTriangle(int first, int second, int third)
{
    return first < second + third && second < first + third && third < first + second;
}