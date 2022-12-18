// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


System.Console.WriteLine("Вот случайный массив");
int rows = 3;
int cols = 3;
int[,] newArray = FillArray(rows, cols);
PrintArray(newArray);
ArithmeticMean(newArray);


void ArithmeticMean(int[,] array)

{
    int count = 0;
    int sum = 0;
    double arithmeticMean = 0;

    while (count < cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                if (j == 0 + count)
                    sum = sum + array[i, j];
        }
        arithmeticMean = (double)sum / rows;
        string arithmeticMeanString = arithmeticMean.ToString("N2");
        System.Console.WriteLine($"Среднее арифметическое в столбце {count + 1} = {arithmeticMeanString}");
        count++;
        sum = 0;
    }

}

int[,] FillArray(int rows, int cols)
{
    int[,] arrayRandom = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arrayRandom[i, j] = new Random().Next(1, 10);

        }
    return arrayRandom;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}\t");
        Console.WriteLine();
    }
}
