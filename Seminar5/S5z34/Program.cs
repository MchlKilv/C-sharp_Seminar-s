// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray();

int[] GetRandomArray()
{
    int[] randomArray = new int[size];

    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = Random.Shared.Next(100, 1000);
    }

    return randomArray;
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"{count} четных чисел в массиве: [{string.Join(", ", array)}]");