// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetNumbers()
{
    System.Console.WriteLine("Введете через пробел значения b1, k1, b2 и k2:");
    double[] array = Array.ConvertAll(Console.ReadLine()!.Split(" "), double.Parse);
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
}

double[] FindPoint(double[] array)
{
    double[] coords = new double[2];
    coords[0] = (array[2] - array[0]) / (array[1] - array[3]);
    coords[1] = array[1] * coords[0] + array[0];
    return coords;
    
}

void CheckValues(double[] array)
{
    if (array.Length == 4)
    {
        double[] coords = FindPoint(array);
        System.Console.Write("Точка пересечения двух прямых, заданных уровнениями y = k1 * x + b1, y = k2 * x + b2, имеет координаты ");
        PrintArray(coords);
    }
    else
    {
        System.Console.WriteLine("Введены некорректные данные! Введите 4 числа.");
    }
}

double[] nums = GetNumbers();
CheckValues(nums);