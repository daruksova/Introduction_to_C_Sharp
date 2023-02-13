// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000) 
{
    System.Console.WriteLine($"Последняя цифра введенного числа {number % 10}");
}
else 
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
