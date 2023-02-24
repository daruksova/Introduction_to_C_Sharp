// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] GetNumbers()
{
    int[] array = new int[2];
    System.Console.Write("Введите число A: ");
    array[0]= Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число B: ");
    array[1] = Convert.ToInt32(Console.ReadLine());
    return array;
}

int DegreeOfNumber(int numA, int numB)
{
    int degree = 1;
    for (int i = 1; i <= numB; i++)
    {
        degree *= numA;
    }
    if (numA < 0 && numA % 2 == 1)
    {
        degree = degree * (-1);
    }
    return degree;
}

int[] array = GetNumbers();
System.Console.WriteLine(DegreeOfNumber(array[0], array[1]));