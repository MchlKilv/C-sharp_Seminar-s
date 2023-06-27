// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер коорд четверти 1-4");
int quart = Convert.ToInt32(Console.ReadLine());

if (quart == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (quart == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (quart == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (quart == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("нет такой четверти");
}