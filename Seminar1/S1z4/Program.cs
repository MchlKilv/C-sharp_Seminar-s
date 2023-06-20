// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число A:");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int NumB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int NumC = Convert.ToInt32(Console.ReadLine());
int max = NumA;
if (NumB > max)
{
    max = NumB;
}
if (NumC > max)
{
    max = NumC;
}

Console.WriteLine("Максимальное число из трех {0} ", max);