int MaxNumber(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 17, 24, 6, 42, 15, 61, 79, 84, 9 };

int max = MaxNumber(MaxNumber(array[0], array[1], array[2]),
                    MaxNumber(array[3], array[4], array[5]),
                    MaxNumber(array[6], array[7], array[8]));

System.Console.WriteLine(max);