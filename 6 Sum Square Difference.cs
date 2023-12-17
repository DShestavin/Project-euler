int numberSquaresSun = 0;
int numberSumSquares = 0;

for (int i = 1; i < 101; i++) // находим сумму квадратов
    numberSquaresSun += (i * i);


for (int i = 1; i < 101; i++) // находим сумму чмсел от 1 до 100
    numberSumSquares += i;

Console.WriteLine(numberSumSquares * numberSumSquares - numberSquaresSun);
