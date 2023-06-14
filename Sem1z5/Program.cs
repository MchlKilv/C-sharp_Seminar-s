// 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
//string N = Console.ReadLine();
int intN = Convert.ToInt32(Console.ReadLine());
for (int i = -intN; i <= intN; i++)
{
    Console.Write("{0}", i);
    if (i < intN)
    {
        Console.Write(", ");
    }
}