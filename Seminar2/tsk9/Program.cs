// выводит число из отрезка {10, 99} и показать наибольшую цифру числа

int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 10;

if (firstDigit > lastDigit)
{
    Console.WriteLine(firstDigit);
}
else if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine("числа равны");
}