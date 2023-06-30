// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int thirdLeftDigit = -1;
// int count = 0;
// // Получаем абсолютное значение числа
// number = Math.Abs(number);

// // Проверяем, достаточно ли цифр в числе для нахождения третьей слева цифры
// if (number > 99)
// {
//     while (count < number)
//     {
//         if (number > 100)
//         {
//             thirdLeftDigit = number % 10;
//         }
//         number /= 10;
//         count++;
//     }
// }

// if (thirdLeftDigit != -1)
// {
//     Console.WriteLine($"Третья слева цифра: {thirdLeftDigit}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

const int ROWS = 4;
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns)
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
}

void PowPrint(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
    
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
PowPrint(myMatrix);
