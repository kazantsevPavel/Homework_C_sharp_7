// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


System.Console.WriteLine("Посмотрите на мой массив и напишите любое число, расположение которого вы хотите узнать");
int rows = 5;
int cols = 5;
int[,] newArray = FillArray(rows, cols);
PrintArray(newArray);
int number = Convert.ToInt32(Console.ReadLine());
Searcher(number, newArray);


void Searcher(int num, int[,] array)
{
    int count = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] == num)
            {
                System.Console.WriteLine($"Ваше число находится в {j + 1} столбце и в {i + 1} строке");
                count++;
            }

        }
    if (count == 0) System.Console.WriteLine("В моём массиве не было такого числа, будьте внимательнее, пожалуйста");
}







int[,] FillArray(int rows, int cols)
{
    int[,] arrayRandom = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arrayRandom[i, j] = new Random().Next(1, 100);

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
