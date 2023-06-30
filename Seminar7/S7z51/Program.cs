// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

// int Diag(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j];
//             }
//         }
//     }
//     return sum;
// }

// for(int i = 0; i < matrix.GetLength(0) && matrix.GetLength(1); i++);

int Diag(int[,] matrix)
{
    int sum = 0;
    int min = matrix.GetLength(0);
    if (min > matrix.GetLength(1))
    {
        min = matrix.GetLength(1);
    }
    for (int i = 0; i < min; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
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

int sum = Diag(myMatrix);
Console.WriteLine("Сумма диагонали " + sum);