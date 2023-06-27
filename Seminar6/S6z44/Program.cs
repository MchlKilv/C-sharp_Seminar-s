// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите количество чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] FibonacciNumbers(int N)
{
    double[]fibonacciNumbers = new double[N];
    fibonacciNumbers[0] = 0;
    fibonacciNumbers[1] = 1;

    for (int i = 2; i < N; i++)
    {
        fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
    }
    return fibonacciNumbers;
}
Console.WriteLine(string.Join(", ", FibonacciNumbers(N)));