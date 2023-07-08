// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

const int rows = 4;
const int columns = 4;

int[,] NewRectangleMatrix(int rows, int colums)
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

void PrintRectangle(int[,] rectangleMatrix)
{
    for (int i = 0; i < rectangleMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < rectangleMatrix.GetLength(1); j++)
        {
            Console.Write($"{rectangleMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinRowSum(int[,] rectangleMatrix)
{
    int minSumRow = int.MaxValue;
    int rowIndex = -1;

    for (int i = 0; i < rectangleMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < rectangleMatrix.GetLength(1); j++)
        {
            sum += rectangleMatrix[i, j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            rowIndex = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Найдена строка {rowIndex + 1}, с наименьшей суммой элементов = {minSumRow}.");
}

int[,] rectangleMatrix = NewRectangleMatrix(rows, columns);
Console.WriteLine();
Console.WriteLine("Задан массив:");
PrintRectangle(rectangleMatrix);
MinRowSum(rectangleMatrix);