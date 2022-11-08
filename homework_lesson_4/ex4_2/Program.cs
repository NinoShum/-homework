/*  Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе. 
Для решения задания использование цикла for является обязательным условием*/

void Sum (int number)
{
    int Summa = 0;
    int temp = 0;
    string N = Math.Abs(number).ToString();
    int lenght = N.Length ;
    for (int i = 1; i <= lenght; i ++ )
    {
        temp = number % 10;
        Summa = Summa + temp;
        number = number /10 ;
    }
    Console.WriteLine($"Сумма цифр равна: {Summa}");
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Sum(number);

