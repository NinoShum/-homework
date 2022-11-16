//Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь

void CountPositiveNumber (int N)
{
    if (N > 0)
    {
        int Count = 0;
        for (int i = 0; i < N; i++ )
        {
            Console.WriteLine("Введите число: ");
            int numeral = Convert.ToInt32(Console.ReadLine());
            if ( numeral > 0 )
            {
                Count = Count + 1;
            }
        }
        Console.WriteLine($"Количество положительных чисел:{Count}");

    }
    else Console.WriteLine("Введите положительное число");
}
Console.WriteLine("Введите количество цифр: ");
int number = Convert.ToInt32(Console.ReadLine());

CountPositiveNumber(number);
