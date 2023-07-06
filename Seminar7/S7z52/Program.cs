// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

const int rows = 3;
const int columns = 4;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--");
}
void ColumnMean(int[,] matrix)
{
    float[] mean = new float[matrix.GetLength(1)];
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        int sum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sum += matrix[row, column];
        }
        mean[column] = (float)sum / matrix.GetLength(0);
    }
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.WriteLine($"Среднее арифметическое элементов в столбце {column}: {mean[column]:f1}");
    }
}

int[,] print = GetRandomArray(rows, columns);
PrintArray(print);
ColumnMean(print);