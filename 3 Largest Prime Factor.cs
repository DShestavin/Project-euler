long number = 600851475143;
int total = 2;
int maxTotal = 0;

while (number != 1)
{
    while (total < number)
    {
        total += 1;
        if (number % total == 0)
        {
            number /= total;
            if (total > maxTotal)
            {
                maxTotal = total;
            }
            break;
        }    
    }
    total = 2;
}

Console.WriteLine(maxTotal);
