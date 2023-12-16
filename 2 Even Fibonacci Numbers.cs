int numberFibonachi1 = 1;
int numberFibonachi2 = 2;
int numberFibonachi3 = 0;
int sumPositivNumbers = 2;

while(numberFibonachi3 < 4000000)
{
    numberFibonachi3 = numberFibonachi1 + numberFibonachi2;
    numberFibonachi1 = numberFibonachi2;
    numberFibonachi2 = numberFibonachi3;
    if (numberFibonachi3 % 2 == 0)
        sumPositivNumbers += numberFibonachi3;
}

Console.WriteLine(sumPositivNumbers);