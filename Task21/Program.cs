// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки А");
Console.Write("х = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.Write("х = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double z2 = Convert.ToDouble(Console.ReadLine());
double dist = Distance(x1, y1, z1, x2, y2, z2);

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distance = Math.Round(Math.Sqrt((xa - xb) * (xa -xb) + (ya -yb) * (ya - yb) + (za - zb) * (za -zb)), 2);
    return distance;
}

Console.WriteLine("Расстояние между точками А и В равно " + dist + ".");