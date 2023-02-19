// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координаты первой точки перез пробел: ");
int[] dotA = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
System.Console.Write("Введите координаты второй точки перез пробел: ");
int[] dotB = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

if (dotA.Length == 3 && dotB.Length == 3)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(dotA[0] - dotB[0], 2) + Math.Pow(dotA[1] - dotB[1], 2) + Math.Pow(dotA[2] - dotB[2], 2)), 3);
    System.Console.WriteLine(distance);
}
else
{
    System.Console.WriteLine("Введены некорректные данные");
}
