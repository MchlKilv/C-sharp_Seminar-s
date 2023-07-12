// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

const int numM = 1;
const int numN = 15;

int SumNaturalNumbers(int startNum, int endNum)
{
    if (endNum <= startNum) return endNum;
    return SumNaturalNumbers(startNum, endNum - 1) + endNum;
}
Console.WriteLine($"Сумма от {numM} до {numN} равна {SumNaturalNumbers(numM, numN)}");