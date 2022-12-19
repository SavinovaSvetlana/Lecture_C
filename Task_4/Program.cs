void FillArray(int[] collection)
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // 1      new int[1] - создать новый массив где будет 10 элементов
FillArray(array);          // 2
PrintArray(array);
Console.WriteLine();       // 3

//Задача: опеределили массив из 10 элементов(1), вызвали метод(2), кторый заполнил массив случайными числами,
//и метод (3), кторый распечатал массив
