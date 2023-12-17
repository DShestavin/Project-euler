long number = 21;
int total = 0; // счетчик количества делителей от 1 до 20

while (total != 20)
{
    for (int i = 1; i < 21; i++)
    {
        if (number % i == 0)
        {
            total++;
        }
    }
    if (total == 20)
        break;
    total = 0;
    number++;
}

Console.WriteLine(number);