int total = 3;
long sumTotal = 2;

while (total < 2000000)
{
    int score = 0; // счетчик количества делителей

    for (int i = 3; i <= total; i += 2) // проверка простое число или нет
    {
        if (total % i == 0)
        {
            score++;
            if (score == 2)
                break; // остановка если делитей 2 и более
        }
    }
    if (score == 1) // сумирование простых чисел
    {
        sumTotal += total;
    }
    total += 2;
}

Console.WriteLine(sumTotal);