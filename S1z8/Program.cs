// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Проверим диапазон от 1 до вашего числа на четность, введите число: ");
int endOfRange = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (endOfRange <= 0)
{
    Console.WriteLine("Ваше чиcло {0} не подходит, нужно число побольше!", endOfRange);
}
else if (endOfRange == 1)
{
    Console.WriteLine("Число {0} нечетное, введите число больше {0}.", endOfRange);
}
else 
Console.WriteLine("Четные числа из диапазона от 1 до {0}:", endOfRange);
while (count <= endOfRange)
{
    if (count % 2 == 0)
        {
            Console.Write("{0}", count);
        }
    if (count == endOfRange)
        {
            Console.Write(".");
        }
    else if (count % 2 != 0)
        {
            Console.Write(", ");
        }
count ++;
}