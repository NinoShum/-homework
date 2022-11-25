/*Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

int Formula(int n)

{
    if (n == 1)
    {
        return 1;
    }
    Console.Write (n+", ");
    return Formula(n-1);
}

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)  
Console.WriteLine("Error");
else
{
int result = Formula(n);
Console.WriteLine(result);}
