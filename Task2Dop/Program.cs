// Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
Console.WriteLine("Введите трехзначное число.");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 999 | N < 100)
    Console.WriteLine("Ошибка. Число должно быть трехзначным");
else
{
    int sum = N % 10 + (N / 10 % 10) + N / 100;
    if (sum % 3 == 0)
        Console.WriteLine("Сумма цифр числа " + N + " кратна 3.");
    else
        Console.WriteLine("Сумма цифр числа " + N + " не кратна 3.");
}