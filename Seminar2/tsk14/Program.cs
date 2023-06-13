// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int oneNumb = Convert.ToInt32(Console.ReadLine());
int twoNumb = Convert.ToInt32(Console.ReadLine());
int resultNumb = oneNumb % twoNumb;
Console.WriteLine(resultNumb);
if (resultNumb != 0)
{
    Console.WriteLine(resultNumb);
}
else
{
    Console.WriteLine ("числа кратные");
}