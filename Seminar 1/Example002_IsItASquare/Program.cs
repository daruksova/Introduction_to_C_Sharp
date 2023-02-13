// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

System.Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}