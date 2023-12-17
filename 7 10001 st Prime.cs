int numbers = 2;
int totalNumber = 1; // номер простого числа

while (totalNumber != 10001)
{
    int total = 0;
    numbers++;
    for (int i = 2; i <= numbers; i++) // проверка простое число или нет
    {
        if (numbers % i == 0)
            total++;
        if (total == 2) 
            break;
    }
    if (total == 1)
        totalNumber++;
}

Console.WriteLine(numbers);