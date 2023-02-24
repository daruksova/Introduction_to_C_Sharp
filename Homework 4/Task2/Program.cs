// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber()
{
    System.Console.WriteLine("Введите число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

int DigitsSum(int number)
{
    int sum = 0;
    while (number % 10 > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int number = GetNumber();
System.Console.WriteLine(DigitsSum(number));