// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int number = 3;
int pow = 5;

int NumberPow(int number, int mult)
{
    if (mult == 0) return 1;
    return NumberPow(number, mult - 1) * number;
}
Console.Write($"{number} в степени {pow} = {NumberPow(number, pow)}");