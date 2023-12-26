int number = 1;
int numb = 0;
int devisorCount = 0;

while (devisorCount < 501)
{
    number++;
    devisorCount = 0;
    numb = 0;
    for (int i = 1; i <= number; i++) //создание треугольного числа
    {
        numb += i;
    }
    for (int i = 1; i <= numb; i++) //поиск делителей
    {
        if (numb % i == 0)
        {
            devisorCount++;
        }
    }
}

Console.WriteLine(numb);