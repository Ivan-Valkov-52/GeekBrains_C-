int[] array = { 15, 23, 3, 45, 4, 12, 89, 0 };

int n = array.Length;
int find = 0;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
