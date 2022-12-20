// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36 

Console.WriteLine("Введите число: ");
int nam = int.Parse(Console.ReadLine()!);
int GetSumNams(int namber)
{
    int sum = 0;
    while (namber > 0)
    {
        sum += namber;
        namber--;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел: {GetSumNams(nam)}");

