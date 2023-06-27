// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numOut = number;
int digitSum = 0;
while (Math.Abs(number) > 0)
{
   digitSum += Math.Abs(number) % 10;
   number /= 10;
}
Console.WriteLine($"Сумма цифр числа {numOut} равна {digitSum}");