// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = string.Empty;

while (decimalNumber > 0)
{
    int remainder = decimalNumber % 2;
    binaryNumber = remainder + binaryNumber;
    decimalNumber /=2;
}
Console.WriteLine($"Число {decimalNumber} в двоичной системе равно: {binaryNumber}");