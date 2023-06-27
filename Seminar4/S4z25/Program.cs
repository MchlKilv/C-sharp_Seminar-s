// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumbs(string nums)
{
    Console.WriteLine(nums);
    return Convert.ToInt32(Console.ReadLine());
}

int mathPow(int numA, int numB)
{
    int mPow = 1;
    for (int i = 0; i < numB; i++)
    {
        mPow = mPow * numA;
    }
    return mPow;
}

int numA = ReadNumbs("Введите число A: ");
int numB = ReadNumbs("Введите число B: ");
if (numB < 0)
{
    Console.WriteLine("Так нельзя");
}
else
{
    Console.WriteLine($"Число А, {numA} с в степени числа B, {numB} = {mathPow(numA, numB)}");
}