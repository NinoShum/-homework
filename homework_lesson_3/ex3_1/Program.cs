// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void testN (int N)
{
    if (N > 9999 && N < 100000)
    {
        Console.WriteLine ("Число состоит из 5 знаков");
        int Temp  = N;
        int Revers = 0;
        int Rest = 0;
        while (Temp > 0)
        {
            Rest = Temp % 10;
            Revers = Revers * 10 + Rest;
            Temp = Temp / 10;
        }
         Console.WriteLine (Revers);
        if (N == Revers) 
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        Console.WriteLine("Число НЕ является палиндромом");
        

    
    }
    else Console.WriteLine ("число НЕ состоит из 5 знаков или содержит знак минус. Введите нужное число");
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

testN(N);
