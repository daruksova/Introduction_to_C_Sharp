//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, string oldvalue, string newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldvalue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, " ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, "к", "К");
Console.WriteLine(newText);
newText = Replace(text, "С", "с");
Console.WriteLine(newText);