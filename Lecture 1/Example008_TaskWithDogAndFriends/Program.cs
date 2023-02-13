int distance = 20;
int minDistance = 10;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int flag = 1;
int time = 0;
int count = 0;

while (distance > minDistance)
{
    if (flag == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        flag = 2;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        flag = 1;    
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}

Console.WriteLine("Собака пробежит от одного друга к другому " + count + " раз");