// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int numM = 1;
int numN = 5;

void NaturalsNumbers(int endNum, int startNum)
{
    if (endNum <= startNum - 1) return;
    NaturalsNumbers(endNum - 1, startNum);
    //Console.Write($" {endNumber}");
    Console.Write(endNum + " ");
}
NaturalsNumbers(numN, numM);