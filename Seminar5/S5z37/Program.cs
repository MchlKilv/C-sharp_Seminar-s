// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray()
{
    int[] arrayRandom = new int[size];

    for (int i = 0; i < arrayRandom.Length; i++)
    {
        arrayRandom[i] = Random.Shared.Next(-9, 10);
    }

    return arrayRandom;
}

int[] array = GetRandomArray();
int[] productArray = new int[(array.Length + 1) / 2];

{
    for (int i = 0; i < productArray.Length; i++)
    {
        productArray[i] = array[i] * array[array.Length - 1 - i];
    }
}
if (array.Length % 2 != 0)
{
    productArray[productArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Произведение пар чисел: [{string.Join(", ", productArray)}]");