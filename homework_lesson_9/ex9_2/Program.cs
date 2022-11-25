/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/


int Summa(int n, int m)

{
    int sum = 0;
    if (n < m)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    
    if (n == m)
        {
            return m;
        }
        return sum = n + Summa(n-1, m);
    

}

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n <= 0 || m <=0)  
Console.WriteLine("Error");
else
{
int result = Summa(n,m);
Console.WriteLine(result);}