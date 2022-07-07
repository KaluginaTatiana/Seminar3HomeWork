// Задача 9. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, 
// второй умножает его на любое натуральное число от 2 до 9, 
// первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
// Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.
double N = 1;
double num1, num2;
double max = 1000;
while (N <= max)
{
    Console.WriteLine("Игрок 1. Введите целое число от 2 до 9.");
    num1 = Convert.ToDouble(Console.ReadLine());
    while (num1 < 2 | num1 > 9 | num1 % 1 != 0)
    {
        if (num1 < 2 | num1 > 9 | num1 % 1 != 0)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Ошибка. Число должно быть целым, в промежутке от 2 до 9.");
            Console.WriteLine(" ");
            Console.WriteLine("Игрок 1. Введите повторно целое число от 2 до 9.");
            num1 = Convert.ToDouble(Console.ReadLine());
        }
    }       
    N = N * num1;
    Console.WriteLine("Результат = " + N + ".");
    if (N > max)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Выиграл Игрок 1!");
        break;
    }
    else
    {
        Console.WriteLine("Игрок 2. Введите целое число от 2 до 9.");
        num2 = Convert.ToDouble(Console.ReadLine());
        while (num2 < 2 | num2 > 9 | num2 % 1 != 0)
        {
            if (num2 < 2 | num2 > 9 | num2 % 1 != 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ошибка. Число должно быть целым, в промежутке от 2 до 9.");
                Console.WriteLine(" ");
                Console.WriteLine("Игрок 2. Введите повторно целое число от 2 до 9.");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
        }
        N = N * num2;
        Console.WriteLine("Результат = " + N + ".");
        if (N > max)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Выиграл Игрок 2!");
            break;
        }
    }
}
Console.WriteLine(" ");
Console.WriteLine("Ура! Поздравляем!");
Console.WriteLine(" ");