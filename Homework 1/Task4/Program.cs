// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("В последовательности нет четных чисел");
}
else if (number > 1)
{
    for (int i = 2; i <= number; i = i + 2 )
    {
        System.Console.Write($"{i} ");
    }
}
else
{
    for (int i = 0; i>= number; i = i - 2 )
    {
        System.Console.Write($"{i} ");
    }
}
