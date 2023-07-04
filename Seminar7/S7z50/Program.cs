// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

const int ROWS = 3;
const int COLUMNS = 4;

int[,] NewMatrix(int rows, int columns)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckMatrix(int[,] matrix)
{
    Console.Write("Введите позицию строки: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите позицию столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
    {
        int value = matrix[row, column];
        Console.WriteLine($"Значение элемента: {value}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве.");
    }
}

int[,] myMatrix = NewMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
CheckMatrix(myMatrix);