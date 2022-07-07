// Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
int[] array = new int[10];
FillArray(array);
PrintArray(array);

void FillArray(int[] collection)
{
    int length = 10;
    int index = 0;
    while (index < length)
    {
        collection[index] = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = 10;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine(" ");
}


