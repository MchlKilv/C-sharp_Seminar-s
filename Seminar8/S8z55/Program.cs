// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.

const int Rows = 4;
const int Columns = 3;

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

int[,] ChangeRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] newArray = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}

int[,] newArray = GetRandomMatrix(Rows, Columns);
Console.WriteLine("Исходный массив:");
PrintArray(newArray);
int[,] chArray = ChangeRows(newArray);
Console.WriteLine("Массив после замены строк на столбцы:");
PrintArray(chArray);