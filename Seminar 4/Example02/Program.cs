// Напишите программу, которая приниимает на вход число и выдаёт количество цифр в числе

int PrintNum(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int DigitCount(int number)
{
    int i = 0;
    while (number > 0)
    {
        number /= 10;
        i++;
    }
    return i;
}

Console.WriteLine(DigitCount(PrintNum("Введете число: ")));
