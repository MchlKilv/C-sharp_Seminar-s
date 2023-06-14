// Задача 2: Напишите программу, которая
// на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A:");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int NumB = Convert.ToInt32(Console.ReadLine());
if (NumA > NumB)
{
    Console.WriteLine("Число А = {0} большее, т. к. больше числа В = {1}.", NumA, NumB);
    Console.WriteLine("Число В = {0} меньшее, т. к. меньше числа А = {1}.", NumB, NumA);
}
else if (NumA < NumB)
{
    Console.WriteLine("Число В = {0} большее, т. к. больше числа А = {1}.", NumB, NumA);
    Console.WriteLine("Число А = {0} меньшее, т. к. меньше числа В = {1}.", NumA, NumB);
}
else
{
    Console.WriteLine("Числа равны, А и В = {0}", NumA, NumB);
}