// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
}

void FindNumber(int[] array, int findN)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findN)
        {
            System.Console.WriteLine("Yes");
            return;
        }
    }
    System.Console.WriteLine("No");
}

int[] array = GenerateArray(12, 1, 9);
PrintArray(array);
FindNumber(array, 5);
