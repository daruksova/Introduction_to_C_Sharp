// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetNumbers()
{
    System.Console.WriteLine("Введете числа через пробел:");
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    return array;
}

int GreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] numbers = GetNumbers();
System.Console.WriteLine("Чисел больше нуля введено " + GreaterThanZero(numbers));
