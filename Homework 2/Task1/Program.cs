// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    System.Console.WriteLine("Вы ввели неверное число");
}
else
{
    int secondDigit = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {secondDigit}");
}
