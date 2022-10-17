/*Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет. */

// ввод числа 
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//проверка числа
if ((number > 99) || (number < -99))
{
    if ((number > 1000) || (number < -1000))
    {
        while ((number > 1000) || (number < -1000)) //если больше трех знаков
        {
            number = number / 10 ;
        }
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра {result}");

}
else Console.WriteLine("Третьей цифры нет");

