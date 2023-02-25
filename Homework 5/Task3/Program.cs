// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + String.Join("  ", array) + "]");
}

double FindMinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double FindMaxElement(double[] array)
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double[] array = GenerateArray(10);
PrintArray(array);
double minElement = FindMinElement(array);
double maxElement = FindMaxElement(array);
System.Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + Math.Round((maxElement - minElement), 2));