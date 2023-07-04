// Задача 53: Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.

const int Rows = 4;
const int Columns = 4;
int[,] GetRandomMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void ChangeRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array[rows - 1, j] = temp;
    }

}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetRandomMatrix(Rows, Columns);
PrintArray(matrix);
ChangeRows(matrix);
Console.WriteLine();
PrintArray(matrix);