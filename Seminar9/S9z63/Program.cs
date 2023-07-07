// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int numN = 5;

void NaturalsNumbers(int endNumber)
{
    if (endNumber <= 0) return;
    NaturalsNumbers(endNumber - 1);
    //Console.Write($" {endNumber}");
    Console.Write(endNumber + " ");
}
NaturalsNumbers(numN);