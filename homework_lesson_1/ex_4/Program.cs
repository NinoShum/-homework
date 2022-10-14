/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// доп.переменная - первое четное число
int count = 2;

if (number >= count)  //даное условие предполагает,что если N<2, то нет чисел для поиска
{
    while (count <= number) 
    {
        Console.Write(count + " ");
        count = count + 2;
    }
} 
else
{
    Console.WriteLine($"До числа {number} нет положительных четных чисел");
}