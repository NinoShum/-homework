/* Напишите программу, которая принимает на вход
 три числа и выдаёт максимальное из этих чисел. */

 // Ввод чисел
Console.Write("Введите X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z: ");
int Z = Convert.ToInt32(Console.ReadLine());

// ввод максимума

int max = X;

//проверка условия

if ( Y > max) max = Y;
if ( Z > max) max = Z;

//ответ
Console.WriteLine("Максимальное число равно " + max);
