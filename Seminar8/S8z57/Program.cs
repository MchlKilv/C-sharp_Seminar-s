// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Элементы [0, 9]
int rows = 6; int columns = 9;
int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(0, 10); // [0,10)
        }
    return matrix;
}

int[] GetFrqOfElem(int[,] array)
{
    int[] originArray = new int[10]; //[0...9]
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            originArray[array[i, j]]++;
        }
    }
    return originArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GMatrix = GetRandomArray(rows, columns);
Console.WriteLine("Исходный массив:");
PrintArray(GMatrix);
int[] GFrequency = GetFrqOfElem(GMatrix);
Console.WriteLine("Частотный словарь элементов массива:");
for (int i = 0; i < GFrequency.Length; ++i)
{
    Console.WriteLine($"Элемент {i} : повторяется {GFrequency[i]} раз");
}