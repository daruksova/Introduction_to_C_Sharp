// Напишите программу, которая принимает на вход координаты двух точек  находит расстояние между ними в 2D пространстве

System.Console.WriteLine("Введите координату x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y первой точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))), 3);
System.Console.WriteLine(distance);