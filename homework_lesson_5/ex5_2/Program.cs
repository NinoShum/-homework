// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.



int [] array = new int [ new Random().Next(4, 10)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,101);
    Console.Write(array[i] + " ");
}

int Sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        Sum += array[i];
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Сумма цифр нечетных позиций равно: {Sum}");
