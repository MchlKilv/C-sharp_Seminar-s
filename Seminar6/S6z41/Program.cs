// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNumers(string input)
{
    Console.Write(input);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

int[] NubersArray(int arrayNumber)
{
    int[] numArray = new int[arrayNumber];
    for (int i = 0; i < numArray.Length; i++) numArray[i] = InputNumers($"Введите {i + 1}-е число: ");
    return numArray;
}

void Print(int[] numArray)
{
    for (int i = 0; i < numArray.Length; i++) Console.Write($"{numArray[i]} ");
    Console.WriteLine();
}

int PosNumbers(int[] numArray)
{
    int count = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if (numArray[i] > 0) count++;
    }
    return count;
}

int arrayNumber = InputNumers("Сколько чисел будем вводить? - ");
int[] numArray;
numArray = NubersArray(arrayNumber);
Print(numArray);
Console.WriteLine($"Чисел больше 0 - {PosNumbers(numArray)}.");