int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > arg1) result = arg2;
    if (arg3 > arg1) result = arg3;
    return result;
}


int[] array = { 10, 23, 31, 14, 51, 62, 71, 81, 19 };
// array[0] = 12;
// Console.WriteLine(array[4]);

int result = Max(Max(array[0]), Max(array[1]), Max(array[2]), Max(array[3]), Max(array[4]), Max(array[5]),
Max(array[6]), Max(array[7]), Max(array[8]));
Console.WriteLine(result);


//НЕ РАБОТАЕТ!!!!!!!!!!!!!

