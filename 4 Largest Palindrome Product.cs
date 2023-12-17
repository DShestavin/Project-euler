int value1 = 999;
int value2 = 999;
int maxPalindom = 0;

while (value1 > 99)
{
    while (value2 > 99)
    {
        string palindom1 = (value1 * value2 / 1000).ToString();
        string palindom2 = (value2 * value1 % 10).ToString() + (value2 * value1 % 100 / 10).ToString() + (value2 * value1 % 1000 / 100).ToString();
        if (palindom1 == palindom2)
        {
            if ((value1 * value2) > maxPalindom)
                maxPalindom = value1 * value2;
        }
        value2--;
    }
    value2 = 999;
    value1--;
}

Console.WriteLine(maxPalindom);