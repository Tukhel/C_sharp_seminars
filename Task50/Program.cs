// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

if (CheckNumberCorrect(array2d, numberRow, numberColumn))
{
    int findElement = FindElement(array2d, numberRow, numberColumn);
    Console.WriteLine($"Значение искомого элемента: {findElement}");
}
else Console.WriteLine("Такой позиции в массиве нет");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

int FindElement(int[,] matrix, int row, int column)
{
    return matrix[row, column];
}

bool CheckNumberCorrect(int[,] matrix, int row, int column)
{
    if (row % 1 == 0 && row >= 0 && column % 1 == 0 && column >= 0
        && matrix.GetLength(0) > row && matrix.GetLength(1) > column) return true;
    else return false;
}