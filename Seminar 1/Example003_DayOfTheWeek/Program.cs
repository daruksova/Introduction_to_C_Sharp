// Напишите программу, которая будет выдавать название дня недели по заданному номеру

System.Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) 
{
    System.Console.WriteLine("Понедельник");
}
else if (day == 2) 
{
    System.Console.WriteLine("Вторник");
}
else if (day == 3) 
{
    System.Console.WriteLine("Среда");
}
else if (day == 4) 
{
    System.Console.WriteLine("Четверг");
}
else if (day == 5) 
{
    System.Console.WriteLine("Пятница");
}
else if (day == 6) 
{
    System.Console.WriteLine("Суббота");
}
else if (day == 7) 
{
    System.Console.WriteLine("Воскресенье");
}
else 
{
    System.Console.WriteLine("Такого дня недели не существует");
}