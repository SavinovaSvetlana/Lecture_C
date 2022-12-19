// Вид 1. Методы ничего не возвращают и не принимают.

void Method1()
{
    Console.WriteLine(" 1 Автор ...");
}
Method1();


// Вид 2. Методы ничего не возвращают, но принимают.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(" 2 msg");



void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: " 3 msg", count: 1);   // Не обязательно писать по порядку, цифра 1 - сколько раз покажет msg



// Вид 3. Методы что-то возвращают, но ничего не принимает.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);



// Вид 4. Методы возвращают и принимают.
string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

