// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

if (number < 10000 || number > 99999) Console.WriteLine("Введено некорректное число!");
else 
{
    bool palindrom = Palindrom(number);
    Console.WriteLine(palindrom ? "Да" : "Нет");
}


bool Palindrom(int num)
{
    int result = 0;
    int copy = num;
    int digit = 0;

    digit = copy % 10; //получаем пятую цифру
    copy = copy / 10; //получаем 4 цифры
    result += digit * 10000;  //пятая цифра становится первой

    digit = copy % 10; //получаем четвертую цифру
    copy = copy / 10; //получаем 3 цифры
    result += digit * 1000; //5, 4 цифры

    digit = copy % 10; //получаем третью цифру
    copy = copy / 10; //получаем 2 цифры
    result += digit * 100; //5, 4, 3 цифры

    digit = copy % 10; //получаем вторую цифру
    copy = copy / 10; //получаем 1 цифру
    result += digit * 10 + copy; //5, 4, 3, 2, 1 цифры

    return result == num;
}