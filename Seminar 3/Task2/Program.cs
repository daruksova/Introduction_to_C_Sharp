// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

System.Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num == 1)
{
    System.Console.WriteLine("Диапазон возможных координат x > 0 и y > 0");
}
else if (num == 2)
{
    System.Console.WriteLine("Диапазон возможных координат x < 0 и y > 0");
}
else if (num == 3)
{
    System.Console.WriteLine("Диапазон возможных координат x < 0 и y < 0");
}
else if (num == 4)
{
    System.Console.WriteLine("Диапазон возможных координат x > 0 и y < 0");
}
else
{
    System.Console.WriteLine("Такой четверти не существует");
} 