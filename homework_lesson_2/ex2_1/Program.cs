/*Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа. */

// Ввод числа
Console.WriteLine("Введите число: ");

// проверка числа
int number = Convert.ToInt32(Console.ReadLine());
if  ((99 < number && number < 1000 ) || ( -1000 < number && number < -99))
{
    // поиск 2 цифры
    //найти последние 2 цифры
    int result = number % 100;
    // ищем 1 цифру из двух 
    result  = result / 10 ;
    Console.WriteLine($"Цифра в центре равна {result}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}