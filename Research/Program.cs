Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int thirdLeftDigit = -1;
int count = 0;
// Получаем абсолютное значение числа
number = Math.Abs(number);

// Проверяем, достаточно ли цифр в числе для нахождения третьей слева цифры
if (number > 99)
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