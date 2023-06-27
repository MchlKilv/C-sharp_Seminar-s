// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты x, y точки A:");
Console.Write("Ax: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay: ");
int Ay = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты x, y точки B:");
Console.Write("Bx: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("By: ");
int By = Convert.ToInt32(Console.ReadLine());

double deltaSquareX = Math.Pow(Ax - Bx, 2);
double deltaSquareY = Math.Pow(Ay - By, 2);

double dist = Math.Sqrt(deltaSquareX+deltaSquareY);
Console.WriteLine ("Расстояние между точками = {0}. ", dist);
Console.Write ($"Округлим, до сотых после запятой = {dist:F2}");