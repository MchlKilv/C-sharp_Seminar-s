// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки:");
Console.Write("Ax: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Az: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("Bx: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("By: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Bz: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double deltaSqrX = Math.Pow(Ax - Bx, 2);
double deltaSqrY = Math.Pow(Ay - By, 2);
double deltaSqrZ = Math.Pow(Az - Bz, 2);

double distBetDot = Math.Sqrt(deltaSqrX+deltaSqrY+deltaSqrZ);
Console.Write ("Расстояние между точками = {0}. ", distBetDot);
Console.Write ($"Eсли округлить, то = {distBetDot:F2}");