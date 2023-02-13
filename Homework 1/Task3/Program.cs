// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное");
}
