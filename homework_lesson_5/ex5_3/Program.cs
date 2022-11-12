// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива

double [] array = new double [ new Random().Next(4, 10)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
}

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;

Console.WriteLine(" ");
Console.WriteLine($"Максимум: {max}");
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Разница: {result}");
