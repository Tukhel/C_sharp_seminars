// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] matrix3D = new int[4, 4, 3];

if (matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2) < 91)
{
    matrix3D = Create3DMatrixInt(matrix3D.GetLength(0), matrix3D.GetLength(1), matrix3D.GetLength(2));
    Print3DMatrix(matrix3D);
}
else Console.WriteLine("Слишком большая матрица");

int[,,] Create3DMatrixInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int number = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = number;
                number++;
            }
        }
    }

    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}