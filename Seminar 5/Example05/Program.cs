// Найдите произведение пар чисел в однгомерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] ProductsPairNumbers(int[] array)
{
    int[] finalArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        finalArray[i] = array[i] * array[array.Length - i - 1];
    }
    return finalArray;
}

int[] array = GenerateArray(5, 0, 10);
PrintArray(array);
PrintArray(ProductsPairNumbers(array));

