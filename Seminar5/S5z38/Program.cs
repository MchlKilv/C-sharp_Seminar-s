// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальными минимальным элементами массива
// (не использовать стандартные функции/методы).

// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray()
{
    int[] naturalNumbersArray = new int[size];

    for (int i = 0; i < naturalNumbersArray.Length; i++)
    {
        naturalNumbersArray[i] = Random.Shared.Next(0, 101);
    }
    Console.WriteLine("Получен массив из натуральных чисел:");
    Console.WriteLine($"[{string.Join(", ", naturalNumbersArray)}]");

    return naturalNumbersArray;
}

int Subtraction(int[] naturalNumbersArray)
{
    int max = naturalNumbersArray[0];
    int min = naturalNumbersArray[0];

    for (int i = 1; i < naturalNumbersArray.Length; i++)
    {
        if (naturalNumbersArray[i] > max)
        {
            max = naturalNumbersArray[i];
        }
        if (naturalNumbersArray[i] < min)
        {
            min = naturalNumbersArray[i];
        }
    }
    Console.WriteLine("Максимальный элемент:\t {0}", max);
    Console.WriteLine("Минимальный элемент:\t {0}", min);
    return max - min;
}

int[] naturalNumbersArray = GetRandomArray();
int subtractedMaxMin = Subtraction(naturalNumbersArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {subtractedMaxMin}.");