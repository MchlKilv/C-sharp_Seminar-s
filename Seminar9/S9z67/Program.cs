// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 145;

int SumOfDigit(int num)
{
    if (num <= 0) return 0;
    return SumOfDigit(num / 10) + num % 10;
    }

Console.Write($"Сумма цифр = {SumOfDigit(number)}");