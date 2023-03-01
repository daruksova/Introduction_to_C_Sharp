Console.WriteLine("Введите Ваше имя: ");
string? userName = Console.ReadLine();
if (userName!.ToLower() == "даша") 
{
    Console.WriteLine("Ура, это же Даша!");
} 
else 
{
    Console.WriteLine("Привет, " + userName);
}
