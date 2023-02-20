// Первая группа методов - ничего не приниают, ничего не возвращают

void Method1 ()
{
    System.Console.WriteLine("Какой-то текст");
}

// Method1();


// Вторая группа методов - принимают аргументы, но ничего не возвращают

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

// Method21("сообщение", 4);
// Method21(count: 3, msg: "text");


// Третья группа методов - ничего не принимают, но что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// System.Console.WriteLine(year);


// Четвертая группа методов - что-то принимает и что-то возвращает

string Method4(int count, string txt)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + txt;
        i++;
    }
    return result;
}

string res = Method4(10, "abc");
System.Console.WriteLine(res);