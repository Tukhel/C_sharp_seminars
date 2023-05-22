// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = SpiralMatrix(7);
PrintMatrix(matrix);

int[,] SpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int digit = 1;

    for(int offset = 0; offset < size / 2; offset++)
    {
        for (int j = offset; j < size - offset; j++)
        {
            matrix[offset, j] = digit;
            digit++;
        }

        for (int i = offset + 1; i < size - offset; i++)
        {
            matrix[i, size - offset - 1] = digit;
            digit++;
        }

        for (int j = size -offset - 2; j >= offset ; j--)
        {
            matrix[size - offset -1, j] = digit;
            digit++;
        }

        for (int i = size - offset - 2; i > offset; i--)
        {
            matrix[i, offset] = digit;
            digit++;
        }
    }
    if(size % 2 != 0) matrix[size / 2, size / 2] = digit;

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