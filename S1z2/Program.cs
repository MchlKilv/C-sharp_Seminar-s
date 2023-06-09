// Задача 2: Напишите программу, которая
// на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A:");
Console.WriteLine("Введите число B:");
int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
if (NumA > NumB)
{
    Console.WriteLine("Число А = {0} больше числа В = {1}.", NumA, NumB);
    Console.WriteLine("Число В = {0} меньше числа А = {1}.", NumB, NumA);
}
else if (NumA < NumB)
{
    Console.WriteLine("Число В = {0} больше числа А = {1}.", NumB, NumA);
    Console.WriteLine("Число А = {0} меньше числа В = {1}.", NumA, NumB);
}
else
{
    Console.WriteLine("Числа равны, А и В = {0}", NumA, NumB);
}