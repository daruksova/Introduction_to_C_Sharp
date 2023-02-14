int MaxNumber(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 1;
int b1 = 17;
int c1 = 4;
int a2 = 7;
int b2 = 15;
int c2 = 21;
int a3 = 24;
int b3 = 0;
int c3 = 9;

int max = MaxNumber(MaxNumber(a1, b1, c1), 
                    MaxNumber(a2, b2, c2), 
                    MaxNumber(a3, b3, c3));

System.Console.WriteLine(max);