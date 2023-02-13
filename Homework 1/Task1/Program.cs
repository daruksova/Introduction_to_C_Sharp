// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    System.Console.WriteLine($"Большее число {number1}, меньшее число {number2}");
}
else if (number2 > number1)
{
    System.Console.WriteLine($"Большее число {number2}, меньшее число {number1}");
}
else
{
    System.Console.WriteLine("Числа равны");
}