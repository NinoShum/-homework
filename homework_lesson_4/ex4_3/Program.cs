/* Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
Заполнение массива производит пользователь. */

 void GetArray (int [] array) 
 {
    for (int i = 0; i < array.Length ; i++)
    {
        Console.Write($"Введите число с индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("[{0}]", string.Join(", ", array));
    
 }

int [] array = new int [8];
GetArray(array);