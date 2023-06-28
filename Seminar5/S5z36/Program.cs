// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray();

int[] GetRandomArray()
{
    int[] randomArray = new int[size];

    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = Random.Shared.Next(-100, 100);
    }

    return randomArray;
}

int SumOfOdd(int[] randomArray)
{
    int oddSum = 0;
    for (int i = 1; i < randomArray.Length; i += 2)
    {
        oddSum += randomArray[i];
    }

    return oddSum;
}

int[] randomArray = GetRandomArray();
int oddSum = SumOfOdd(randomArray);

Console.WriteLine($"Сумма элементов с нечётным индексом {oddSum} в массиве: [{string.Join(", ", randomArray)}]");