// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. Т е отриц, доли и положительные
/*
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max);
    return array;
}



void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + Math.Round(new Random().NextDouble(), 1) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(-10, 10);
    return array;
}

int rows = new Random().Next(2,5);
int columns = new Random().Next(2,6);

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);

Console.Write("Input a number of row: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of column: ");
int j = Convert.ToInt32(Console.ReadLine());

bool CheckPosition(int[,] array, int i, int j)
{
    if(i<= array.GetLength(0) && i>=0 &&
        j<=array.GetLength(1) && j>=0) return true;
    else return false;
}

if(CheckPosition(myArray, i, j) == true) Console.WriteLine(myArray[i,j]);
else Console.WriteLine("Error! There are no numbers with such indexes in the matrix");
*/


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Double!
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //int[,,] трёхмерный массив.
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible integer value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible integer value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

double[] FillAverageArray(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];
        newArray[j] = sum / array.GetLength(0);
    }
    return newArray;
}

void ShowNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],1) + " ");
    Console.WriteLine();
}

double[] newArray = FillAverageArray(myArray);
ShowNewArray(newArray);
*/
