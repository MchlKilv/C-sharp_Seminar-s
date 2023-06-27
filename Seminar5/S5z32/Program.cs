// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray()
{
    int[] arrayOrigin = new int[size];

    for (int i = 0; i < arrayOrigin.Length; i++)
    {
        arrayOrigin[i] = Random.Shared.Next(-9, 10);
    }

    return arrayOrigin;
}

int[] ChangingArray(int[] arrayOrigin)
{
    int[] arrayChg = new int[size];
    for (int i = 0; i < arrayOrigin.Length; i++)
    {
        arrayChg[i] = -arrayOrigin[i];
    }
    return arrayChg;
}

int[] originArray = GetRandomArray();
int[] changedArray = ChangingArray(originArray);

Console.WriteLine($"Оригинальный массив |--------------------------------------------------> [{string.Join(", ", originArray)}]");
Console.WriteLine($"Он же после замены элементов с положительных на отрицательные и наоборот [{string.Join(", ", changedArray)}]");