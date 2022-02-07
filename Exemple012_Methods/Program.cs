// Вид 1 Ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор Илья Б.");
}
//Method1();

// Вид 2 Что то принимает, ничего не возвращает

void Method2(string msg, int count)

{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2("Текст", 3);
//Method2(count: 4, msg: "Трали Вали");

// Вид 3 Ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4 Что-то принимают, что-то возвращают

//string Method4( int count, string text)
//{
//int i = 0;
//string result = String.Empty;

//while (i < count)
//{
//    result = result + text;
//    i++;
//}
//return result;
//}

//string res = Method4(2, "z");
//Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
        {
            result = result + text;
        }
    return result;
}

string res = Method4(5, "z");
//Console.WriteLine(res);