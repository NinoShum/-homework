/* Напишите программу, которая будет принимать от пользователя позицию (M, N) 
двумерного массива и возвращать значение элемента, стоящего в этой позиции.
 Если такой позиции в массиве нет, то сообщить об этом пользователю.
  Сгенерировать массив случайным образом. Размерность массива определить 
  самостоятельно. Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе.*/


int[,] NewArray (int m, int n)
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

void FindPosition (int [,] array, int P1, int P2)
{
    if ((P1 <0 || P1 > array.GetLength(0)) || (P2 < 0 || P2 > array.GetLength(1)))
    {
         Console.WriteLine("Нет такой позиции");
    }
    else
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (P1 == i && P2 == j) 
            {
                Console.WriteLine();
                 Console.WriteLine(array[i,j]);
            }


        }
       
    }
}

Console.WriteLine("Введите позицию в Строках: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию в столбцах: ");
int N = Convert.ToInt32(Console.ReadLine());

int ArrayM = new Random().Next(2,6);
int ArrayN = new Random().Next(3,5);

int [,] ArrayTab = NewArray(ArrayM,ArrayN);

FindPosition(ArrayTab, M, N);
