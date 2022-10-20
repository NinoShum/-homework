// Напишите программу, 
// которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

void PrintResult (int N)
{
    if (N >= 1)
    {
        for (int i = 1; i <= N; i++)
        {
        double Result = Math.Pow(i, 3);
        Console.WriteLine(Result);
        }
    }
    else Console.WriteLine("Число N не содержит чисел больше 0");
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintResult(N);
