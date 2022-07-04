// Задача 1. Рассчитать значение y при заданном x по формуле
// y = (sin(x))^2, при х > 0
// y = 1 - 2*sin((x)^2), при x <= 0
Console.WriteLine("Введите x в градусах");
double angle_grad = Convert.ToDouble(Console.ReadLine());
double angle_rad = Math.PI * angle_grad / 180;
double angle_rad_sqr = Math.PI * Math.Pow(angle_grad, 2) / 180;
double y;
if (angle_grad > 0)
{
    y = Math.Round(Math.Pow(Math.Sin(angle_rad), 2), 3);
}
else
{
    y = Math.Round(1 - 2 * Math.Sin(angle_rad_sqr), 3);
}
Console.WriteLine("y = " + y);