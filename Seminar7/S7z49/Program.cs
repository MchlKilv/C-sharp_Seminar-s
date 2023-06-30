// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса нечётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 9 2 3

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// const int ROWS = 4;
// const int COLUMNS = 4;

// int[,] GetRandomMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Random.Shared.Next(1, 10);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// void PowPrint(int[,] matrix)
// {
//     for (int i = 1; i < matrix.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j += 2)
//         {
//             matrix[i, j] *= matrix[i, j];
//             Console.Write($"{matrix[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
// PrintMatrix(myMatrix);
// int[,] powMatrix = PowPrint(myMatrix);
// PowPrint(myMatrix);


const int Rows = 4;
const int Columns = 4;
int[,] GetRandomMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)   //i stroli     j stolbtsy
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

int[,] ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
ChangeMatrix(myMatrix);
PrintMatrix(myMatrix);