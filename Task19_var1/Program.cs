// Задача 19
// Напишите программу, которая принимает на вход любое целое число и проверяет, является ли оно палиндромом.
// Не работает на числе больше 2 147 483 647
Console.WriteLine("Введите любое целое положительное число.");
int num = Convert.ToInt32(Console.ReadLine());
int length = Razryadnost(num);
int[] array = new int[length];
int indexMax = length - 1;
int index = indexMax;
int newNum = num;
while (index >= 0)
{
    array[index] = newNum % 10;
    newNum = newNum / 10;
    index--;

}
int count = 0;
while (count < length / 2)
{
    if (array[count] == array[indexMax])
    {
        count++;
        indexMax--;
    }
    else
    {
        Console.WriteLine("Число " + num + " не является палиндромом.");
        break;
    }
}
if (count == length / 2)
    Console.WriteLine("Число " + num + " является палиндромом.");

int Razryadnost(int number)
{
    int count = 1;
    while (number / 10 != 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}