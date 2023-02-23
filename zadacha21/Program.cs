// Задача 21. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance2D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    return Math.Round(distance, 2);
}

Console.Write("Введите координату Х точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Distance2D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine(result);