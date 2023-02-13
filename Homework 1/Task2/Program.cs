// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 == number2 && number2 == number3)
{
    System.Console.WriteLine("Все числа равны");
}
else if (number1 >= number2 && number1 >= number3)
{
    System.Console.WriteLine($"Максимальное число {max}");
}
else if (number2 >= number1 && number2 >= number3)
{
    max = number2;
    System.Console.WriteLine($"Максимальное число равно {max}");
}
else
{
    max = number3;
    System.Console.WriteLine($"Максимальное число равно {max}");
}