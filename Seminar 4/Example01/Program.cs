// Напишите программу, которая принимает на вход число А и выдаёт сумму чисел от 1 до А.

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int sum = Sum(num);
System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");