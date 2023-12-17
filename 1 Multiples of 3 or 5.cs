int number = 0;
int sumNumbers = 0; 

while (number < 1000)
{
    if (number % 3 == 0 || number % 5 == 0)
        sumNumbers += number;
    number++;
}

Console.WriteLine(sumNumbers);