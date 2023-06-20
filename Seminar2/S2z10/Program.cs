// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
string input = Console.ReadLine();

if (input.Length == 3 && int.TryParse(input, out int number))
{
    int secDigit = (number / 10) % 10;
    Console.WriteLine("Вторая цифра числа: {0}", secDigit);
}
else
{
    Console.WriteLine("Некорректный ввод. Введите трёхзначное число.");
}