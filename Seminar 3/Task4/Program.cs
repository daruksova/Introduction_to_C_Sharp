// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        System.Console.WriteLine($"{i} {Math.Pow(i, 2)}");
    }
}
else
{
    for (int i = 1; i >= N; i--)
    {
        System.Console.WriteLine($"{i} {Math.Pow(i, 2)}");
    }
}

