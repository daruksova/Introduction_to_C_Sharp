// Напишите программу замены элементов массива: положительные элементы замените на
// соответтвующие отрицательные, и наоборот.

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

void ReplacingSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] array = GenerateArray(12, -9, 9);
PrintArray(array);
ReplacingSign(array);
PrintArray(array);
