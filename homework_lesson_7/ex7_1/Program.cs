/*Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво).
 Округлите значения, генерируемые Random до двух знаков после запятой.*/

double[,] CreateArray (int m, int n)
{
    double [,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble() * 100;
            array[i,j] = Math.Round(array[i,j],2);
            
        }  

    }

    return array;
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();

    }

   
}

Console.WriteLine("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());

double [,] ResaltArray = CreateArray(M,N);

PrintArray(ResaltArray);



