// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
double endOfRange = Convert.ToDouble(Console.ReadLine());

if (endOfRange <= 0)
{
    Console.WriteLine("Ваше чиcло {0} не подходит, нужно число побольше!", endOfRange);
}
else if (endOfRange == 1)
{
    Console.WriteLine("Диапазон слишком мал, введите число больше {0}.", endOfRange);
}
else 
Console.WriteLine("Кубы чисел из диапазона от 1 до {0}:", endOfRange);
for (int i = 1; i <= endOfRange; i++)
{
    double cube = Math.Pow(i, 3);
    if (i < endOfRange)
    {
        Console.Write("{0}, ", cube);
    }
    else
    {
    Console.Write("{0}.", cube);
    }
}