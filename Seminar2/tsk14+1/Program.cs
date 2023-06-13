// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

//

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1 % 7;
int number3 = number1 % 23;
if(number2 == 0 && number3 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}