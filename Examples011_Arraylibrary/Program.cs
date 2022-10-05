void FillArray(int[] collection) // Метод который заполняет наш массив рандомными числами от 1 до 9.
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод который выводит наш массив в консоль
{
    int index = 0;
    while (index < col.Length)
    {
        Console.Write(col[index]);
        Console.Write(" ");
        index++;
    }
}

int IndexOf(int[] array, int find) // Метод для нахождения позиции элемента в массиве
{
    int index = 0;
    int position = -1;
    while (index < array.Length)
    {
        if (array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

Console.Clear();

int[] array = new int[10]; // Создали массив в котором {0,0,0,0,0,0,0,0,0,0}

FillArray(array); // Вызвали метод который заполнил наш массив array[]
PrintArray(array); // Вызвали метод, который вывел массив array[] в консоль 
Console.WriteLine();
int pos = IndexOf(array, 345);
Console.Write("Индекс массива равен " + pos);