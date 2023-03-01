// Напишите программу, которая будет преобразовывать десятичное число в двоичное

int InputNumber()
{
    System.Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] ToBinary(int number)
{
    int count = 0;
    int num = number;
    while (num > 0)
    {
        num = num / 2;
        count += 1;
    }
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = number % 2;
        number = number / 2;
    }
    Array.Reverse(array);
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join("", array));
}

int number = InputNumber();
PrintArray(ToBinary(number)); 

// Решение с помощью рекурсии

// void ToBinary(int number)
// {
//     if (number == 0) return;
//     ToBinary(number / 2);
//     System.Console.Write(number % 2);
// }

// ToBinary(number);