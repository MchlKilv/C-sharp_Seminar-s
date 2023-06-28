// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> нет


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

Console.Write("Введите число для поиска в массиве: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (searchNumber == array[i])
    {
        count++;
        break;
    }
}
if (count == 1)
{
    Console.WriteLine($"Да, число {searchNumber} в массиве [{string.Join(", ", array)}]");
}
else
{
    Console.WriteLine($"Нет, число {searchNumber} не в массиве [{string.Join(", ", array)}]");
}