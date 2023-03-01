// Напишите программу, которая приниает на вход три числа и проверяяет,
// может ли существовать треугольник со сторонами такой длины.
// Каждая сторона треугольника меньше суммы дувх других сторон.

int[] InputArray()
{
    System.Console.Write("Введите стороны треугольника через пробел: ");
    int[] triangle = new int[3];
    triangle = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    return triangle;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
}

void IsItTriangle(int[] array)
{
    if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0])
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}

int[] triangle = InputArray();
PrintArray(triangle);
IsItTriangle(triangle);
