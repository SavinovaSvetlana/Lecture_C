// Найти элемент массива

int[] array = { 10, 23, 31, 14, 51, 62, 71, 81, 19 };

int n = array.Length;
int find = 14;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
