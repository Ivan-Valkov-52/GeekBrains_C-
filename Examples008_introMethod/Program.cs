int Max(int arg1, int arg2, int arg3) // Метод который ищет максимум из 3 чисел
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.Clear();

int a1 = 15;
int b1 = 3;
int c1 = 7;
int a2 = 25;
int b2 = 6;
int c2 = 1823;
int a3 = 191;
int b3 = 4;
int c3 = 9;

// Первый вариант
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // Второй вариант


Console.WriteLine("max = " + max);