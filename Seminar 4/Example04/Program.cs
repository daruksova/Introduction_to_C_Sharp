// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join(" ", array));
};

PrintArray(CreateArray(10));