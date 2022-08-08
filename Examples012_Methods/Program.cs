//Вид 1
void Method()
{
    Console.WriteLine("Автор ...");
}
//Methods();
//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");
//Вид 2.1
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
//Вид 4
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}
string result = Method4(10, "z");
Console.WriteLine(result);*/
//Вид for
string Method5(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string result = Method5(10, "z");
Console.WriteLine(result);