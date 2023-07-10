// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

const int rows = 3;
const int columns = 2;

int[,] NewMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void PrintPairMatrix(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + " ");
        }
        Console.Write("| ");

        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyPairMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplyResult = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            multiplyResult[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return multiplyResult;
}

void PrintResult(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = NewMatrix(rows, columns);
int[,] matrix2 = NewMatrix(rows, columns);
int[,] resultMatrix = MultiplyPairMatrix(matrix1, matrix2);
Console.WriteLine("Заданы матрицы:");
PrintPairMatrix(matrix1, matrix2);
Console.WriteLine("После умножения элементов:");
PrintResult(resultMatrix);