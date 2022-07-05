// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите целое положительное число, не равное нулю.");
double n = Convert.ToDouble(Console.ReadLine());
if ( n < 1 || n % 1 != 0 )
Console.WriteLine("Ошибка. Введите целое положительное число, не равное нулю.");
else 
SqrNumbers(n);

void SqrNumbers(double number)
{
    double sqr = 1;
    while (sqr <= number)
    {
        Console.Write(Math.Pow(sqr, 3) + " ");
        sqr++;
    }
    Console.WriteLine(" ");
}
