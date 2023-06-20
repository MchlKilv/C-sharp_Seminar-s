// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число для проверки на четность: ");
// проверка на ввод целого числа
int parCheck;
while (!int.TryParse(Console.ReadLine(), out parCheck))
Console.Write("Что-то пошло не так, разве бывают такие целые числа!\nПросьба повторить ввод числа: ");
// int parCheck = Convert.ToInt32(Console.ReadLine()); убрал, т. к. нашел как проверить ввод
if (parCheck % 2 == 0)
{
    Console.WriteLine("Число {0} - четное", parCheck);
}
else
{
    Console.WriteLine("Число {0} - нечетное", parCheck);
}