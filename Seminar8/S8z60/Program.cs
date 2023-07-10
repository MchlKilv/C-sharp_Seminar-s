// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

const int rows = 2;
const int columns = 2;
const int pages = 2;

int[] NewTwoDigit(int rows, int columns, int pages)
{
    int minDigit = 10;
    int maxDigit = 100;
    int[] digits = new int[rows * columns * pages];

    for (int i = 0; i < rows * columns * pages && i < maxDigit - minDigit; i++)
    {
        digits[i] = minDigit + i;
    }
    for (int i = rows * columns * pages - 1; i >= 0; i--)
    {
        int j = Random.Shared.Next(i + 1);
        int temp = digits[i];
        digits[i] = digits[j];
        digits[j] = temp;
    }
    return digits;
}

int[,,] NewThreeDimensionalArray(int rows, int columns, int pages, int[] digits)
{
    int[,,] newArray = new int[rows, columns, pages];
    int index = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i, j, k] = digits[index];
                index++;
            }
        }
    }
    return newArray;
}

void PrintMatrix(int[,,] threeDmatrix)
{
    for (int i = 0; i < threeDmatrix.GetLength(1); i++)
    {
        for (int j = 0; j < threeDmatrix.GetLength(1); ++j)
        {
            for (int k = 0; k < threeDmatrix.GetLength(2); ++k)
            {
                Console.Write($"{threeDmatrix[i, j, k]}{(i, j, k)} ");
            }
            Console.WriteLine();
        }
    }
}

int[] digits = NewTwoDigit(rows, columns, pages);
int[,,] threeDmatrix = NewThreeDimensionalArray(rows, columns, pages, digits);
Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел:");
PrintMatrix(threeDmatrix);