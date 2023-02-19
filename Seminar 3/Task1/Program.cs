// Напишите программу, которая принимает на вход координаты точки (X и Y), где X и Y не равны нулю, и выдает номер четверти плоскости, в которой находитя эта точка.

int[] coords = new int[2];
System.Console.Write("Введите X: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if (coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine("Мы находимся в первой четверти");
}
else if (coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("Мы находимся во второй четверти");
}
else if (coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("Мы находимся в третьей четверти");
}
else if (coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("Мы находимся в четвертой четверти");
}
else
{
    System.Console.WriteLine("Координата лежит на осях");
}