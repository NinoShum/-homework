// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// формула 
// double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2))

double Formula( int x1, int y1, int z1, int x2, int y2, int z2 )
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}

Console.WriteLine("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Formula(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между точками {distance}");