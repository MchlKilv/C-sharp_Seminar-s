// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int thirdLeftDigit = -1;                // Если нет третьей цифры
int count = 0;
number = Math.Abs(number);              // Получаем абсолютное значение числа
if (number > 99)                        // Проверяем, достаточно ли цифр в числе для нахождения третьей слева цифры
{
    while (count < number)
    {
        if (number > 100)
        {
            thirdLeftDigit = number % 10;
        }
        number /= 10;
        count++;
    }
}
if (thirdLeftDigit != -1)
{
    Console.WriteLine($"Третья слева цифра: {thirdLeftDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}