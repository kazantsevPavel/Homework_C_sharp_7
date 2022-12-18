// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. 
//Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] newArray = FillArray(rows, cols);
newArray[4, 4] = 1;
PrintArray(newArray);

int[,] sortArray = BubbleSort(newArray);
System.Console.WriteLine();
PrintArray(sortArray);



int[,] FillArray(int rows, int cols)
{
    int[,] arrayRandom = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arrayRandom[i, j] = new Random().Next(2, 10);

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


int[,] BubbleSort(int[,] mas) // сортировка
{   
    int min = mas[0, 0];
    int minIndxRows = 0;
    int minIndxCols = 0;
    int countRows = 0;
    int countCols = 0;

    while (countRows < rows)
    {
        min = mas[countRows, countCols];
        minIndxRows = countRows;
        minIndxCols = countCols; 

        for (int i = 0 + countRows; i < rows; i++)
        {
            for (int j = 0 + countCols; j < cols; j++)
            {
                if (mas[i, j] < min)
                {
                    mas[minIndxRows, minIndxCols] = mas[i, j];
                    mas[i, j] = min;            
                    min = mas[minIndxRows, minIndxCols];
                    
                }
            }
        }
        
        countCols++;
        
        if (countCols % (cols) == 0)
        {
            countCols = 0;
            countRows++;
        }
        //System.Console.WriteLine(countRows);
        //System.Console.WriteLine(countCols);
        
    }

    return mas;
}

