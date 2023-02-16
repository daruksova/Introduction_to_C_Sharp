// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    System.Console.WriteLine("Такого дня недели не существует");
}
else if (day < 6)
{
    System.Console.WriteLine("Этот день не выходной");
}
else
{
    System.Console.WriteLine("Этот день выходной");
}