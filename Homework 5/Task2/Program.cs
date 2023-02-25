// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ganerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}

void printArray(int[] array)
{
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
}

int sumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = ganerateArray(10, -30, 30);
printArray(array);
System.Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях, равна " + sumOddPositions(array));