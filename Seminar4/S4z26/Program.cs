// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int func(int number)
{
    int colDigit = 0;
    while (number > 0)
    {
        number /= 10;
        colDigit++;
    }
    return colDigit;
}
int number = ReadInt();
int colDigit = func(number);

Console.WriteLine($"Число состоит из {colDigit} цифр");