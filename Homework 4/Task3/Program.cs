// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join(" ", array));
};

PrintArray(CreateArray(8));