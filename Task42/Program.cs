// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите целое, положительное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number  <= 0) Console.WriteLine("Введено не верное число");
else
{
    int resultBin = DecToBin(number);
    Console.WriteLine(resultBin);

}

int DecToBin(int num)
{
    int result = 0;
    int count = 1;

    while (num > 0)
    {
        result += num % 2 * count;
        num /= 2;
        count *= 10;
    }

    return result;
}