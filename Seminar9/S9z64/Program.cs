﻿// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int numN = 8;

void NaturalsNumbers(int startNum)
{
    Console.Write(startNum + " ");
    if (startNum - 1 <= 0) return;
    NaturalsNumbers(startNum - 1);
}
NaturalsNumbers(numN);