// Работа с текстом. Дан текст и нужно все пробелы заменить черточками,
// маленькие буквы к заменить большими К, а маленькие с заменить на 
// большие С. 

string text = "В один прекрасный день они вышли на улицу погулять. Там столнулись "
            + "с одной проблеммой. Решить ее удалось при помощи бегства." 
            + "Принцип прост, проблем много, а я у мамы один. Бежать. ";



string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == oldValue) 
            result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        
    }
    return result;
}

//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
