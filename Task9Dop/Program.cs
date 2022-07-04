// Задача 9. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, 
// второй умножает его на любое натуральное число от 2 до 9, 
// первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
// Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.
int N = 1;
int num1, num2;
while (N <= 1000)
{
    Console.WriteLine("Игрок 1. Введите число от 2 до 9.");
    num1 = Convert.ToInt32(Console.ReadLine());
    N = N * num1;
    Console.WriteLine("Результат = " + N + ".");
    if (N > 1000)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Выиграл Игрок 1!");
        break;
    }
    else
    {
        Console.WriteLine("Игрок 2. Введите число от 2 до 9.");
        num2 = Convert.ToInt32(Console.ReadLine());
        N = N * num2;
        Console.WriteLine("Результат = " + N + ".");
        if (N > 1000)
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