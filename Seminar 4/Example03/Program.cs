// Напишите программу, которая принимает на вход число N и выдаёт произведение чисе от 1 до N

int PrintNum(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int ProductNums(int N)
{
    int product = 1;
    for (int i = 1; i <= N; i++)
    {
        product *= i;
    }
    return product;
}

System.Console.WriteLine(ProductNums(PrintNum("Введите число: ")));