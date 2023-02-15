// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

System.Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int div = number1 % number2;
if (div == 0)
{
    System.Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else 
{
    System.Console.WriteLine(div);
}