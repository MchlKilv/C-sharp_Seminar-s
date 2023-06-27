// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] GetRandonArray()
{
    int[] array = new int[12];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }

    return array;
}

int SumPositiveElements(int[] array)
{
    int sumOfPositiveElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumOfPositiveElements += array[i]; // sumOfPositiveElements = sumOfPositiveElements + array[i];
        }
    }

    return sumOfPositiveElements;
}

int SumNegativeElements(int[] array)
{
    int sumOfNegativeElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumOfNegativeElements += array[i];
        }
    }

    return sumOfNegativeElements;
}

int[] myArray = GetRandonArray();
int sumPositive = SumPositiveElements(myArray);
int sumNegative = SumNegativeElements(myArray);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");