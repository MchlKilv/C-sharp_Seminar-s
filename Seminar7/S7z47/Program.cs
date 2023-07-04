// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int ROWS = 3;
const int COLUMNS = 4;
const float MINVALUE = -10;
const float MAXVALUE = 10;

float[,] GetRandomMatrix(int rows, int columns, float minValue, float maxValue)
{
    float[,] matrix = new float[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rndValue = Random.Shared.NextDouble();
            float rndFloat = (float)(rndValue * (maxValue - minValue) + minValue);
            matrix[i, j] = rndFloat;
        }
    }

    return matrix;
}

void PrintMatrix(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f1}\t ");
        }
        Console.WriteLine();
    }
}

float[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS, MINVALUE, MAXVALUE);
PrintMatrix(myMatrix);