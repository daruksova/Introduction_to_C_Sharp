// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Random num = new Random();
int number = num.Next(100, 1000);

System.Console.WriteLine(number);

int figure1 = number / 100;
int figure2 = number % 10;

System.Console.WriteLine(figure1 * 10 + figure2);