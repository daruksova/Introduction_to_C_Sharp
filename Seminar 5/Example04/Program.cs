// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99]

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

int FindNumbers(int[] array, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue)
        {
            count += 1;
        }
    }
    return count;
}

int[] array = GenerateArray(10, 0, 100);
PrintArray(array);
System.Console.WriteLine(FindNumbers(array, 10, 99));

