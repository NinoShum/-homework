﻿/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.*/

//ввод числа
Console.WriteLine("Введите число от 1 до 7, соответствующее дню недели: ");
int Day = Convert.ToInt32(Console.ReadLine());

// проверка числа
if ( Day > 0 && Day < 8)
{
    if (Day == 7 || Day == 6)
    {
        Console.WriteLine("Да, это выходной");
    }
    else Console.WriteLine("Нет, это рабочий день");
}
else Console.WriteLine("Число не соответствует дню недели");
