// Напишите программу, которая перевернёт одномерный массив
// (Последний элемент будет на первом месте, а первый на последнем и т.д.)

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

void ArrayReversal(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int j = array[i];    
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = j;
    }
}

int[] array = GenerateArray(9, -9, 9);
PrintArray(array);
ArrayReversal(array);
PrintArray(array);
