/* Напишите программу, которая принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Для решения задания использование цикла for является обязательным условием. 
Не использовать встроенный метод возведения в степень.*/

void Calculation( int number, int N)
{
    if (N > 0)
    {
        int result = 1;
        for (int i = 1; i <= N; i++)
        {
            result = result * number;
        }
        Console.WriteLine($"Число в степени равно: {result}");

    }
    if (N == 0) 
    {
            int result = 1;
            result = 1 * 1;
            Console.WriteLine($"Число в степени равно: {result}");

    }
    if (N < 0)
    {
        int N1 = Math.Abs(N);
        int result = 1;
        for (int i = 1; i <= N1; i++)
        {
            result = (1 / (result * number));
        }
        Console.WriteLine($"Число в степени равно: {result}");

    }

}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int N = Convert.ToInt32(Console.ReadLine());

Calculation(number, N);

