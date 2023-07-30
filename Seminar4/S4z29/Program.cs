// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Console.WriteLine("Введите 8 элементов массива:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Элемент {i + 1}: ");
    string input = Console.ReadLine()!;
    int element;

    if (int.TryParse(input, out element))
    {
        array[i] = element;
    }
    else
    {
        Console.WriteLine("Неверный формат числа. Попробуйте снова.");
        i--; // Уменьшаем счетчик, чтобы повторно запросить ввод для текущего элемента
    }
}
Console.WriteLine("Элементы массива:");
foreach (int element in array)
{
    Console.WriteLine(element);
}