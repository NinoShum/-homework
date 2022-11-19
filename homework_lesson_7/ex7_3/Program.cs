/*Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.*/

int[,] GetNewArray (int m, int n)
{
    int [,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,11);
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }

    return array;
}

void FindArithmeticMean (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double SumMean = 0;
        double Sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum = Sum + array[i,j];
        }
        SumMean = Sum / array.GetLength(0);
        SumMean = Math.Round(SumMean,2);

        Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое столбца с индексом {j}:{SumMean}");
    
    }

}

Console.WriteLine("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,] NewArray = GetNewArray(M,N);

FindArithmeticMean(NewArray);
