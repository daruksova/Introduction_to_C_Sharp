// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Random random = new Random();
int number = random.Next(10, 100);
int figure1 = number / 10;
int figure2 = number % 10;

System.Console.WriteLine(number);

if (figure1 >= figure2)
{
    System.Console.WriteLine(figure1);
}
else 
{
    System.Console.WriteLine(figure2);
}