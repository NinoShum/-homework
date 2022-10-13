/* Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее. */

 // ввод чисел
Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число Б: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// проверка чисел

if ( numberA > numberB )
{
    Console.WriteLine ("Число А больше числа Б");
}
else
if ( numberA == numberB)
{
    Console.WriteLine ("Число А равно числу Б");
}
else
{
    Console.WriteLine ("Число А меньше числа Б");
}