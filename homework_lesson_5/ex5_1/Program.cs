/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int [] array = new int [ new Random().Next(4, 10)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Количество четных цифр равно: {count}");