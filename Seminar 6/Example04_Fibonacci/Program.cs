// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа: 0 и 1.

int GetNum()
{
    System.Console.Write("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join(", ", array));
}

int N = GetNum();
PrintArray(Fibonacci(N));