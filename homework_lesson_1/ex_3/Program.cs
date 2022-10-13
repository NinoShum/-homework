/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// проверка

if ( number % 2 == 0 ) 
{
    Console.WriteLine ("Четное");
}
else 
{
    Console.WriteLine ("Не четное");
}