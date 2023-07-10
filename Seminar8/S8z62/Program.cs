// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

const int n = 4;
const int m = 4;

int[,] SpiralFill(int n, int m)
{
    int[,] newMatrix = new int[n, m];
    int row = 0;
    int column = 0;
    int stepOnRow = 0;
    int stepOnColumn = 1;
    int startNumber = 1;

    for (int i = 0; i < n * m; i++)
    {
        newMatrix[row, column] = startNumber;
        startNumber++;
        if (row + stepOnRow >= n || row + stepOnRow < 0 ||
            column + stepOnColumn >= m || column + stepOnColumn < 0 ||
            newMatrix[row + stepOnRow, column + stepOnColumn] != 0)
        {
            int temp = stepOnRow;
            stepOnRow = stepOnColumn;
            stepOnColumn = -temp;
        }
        row += stepOnRow;
        column += stepOnColumn;
    }
    return newMatrix;
}

void PrintMatrix(int[,] spiralMatrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{0:D2} ", spiralMatrix[i, j]);
            Thread.Sleep(350);
        }
        Console.WriteLine();
    }
}

int[,] spiralMatrix = SpiralFill(n, m);
Console.WriteLine("Заполнение по спирали");
PrintMatrix(spiralMatrix);