// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumberCount(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i] % 2 == 0) count ++;
    return count;  
}

Console.Write("Input a number: "); //15
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: "); //100
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: "); //999
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int count = EvenNumberCount(myArray);
Console.WriteLine($"Count of even numbers in array is {count}");
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumEvenIndex(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Write("Input a number: "); //15
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: "); //100
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: "); //999
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int sum = SumEvenIndex(myArray);

Console.WriteLine($"Sum of even possition elements is {sum}");
*/

// Задайте массив вещественных(double, Random NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива. Можно сформировать отдельное число int, отдельное double чтобы сформ?

double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        double randomDouble = new Random().NextDouble();
        randomDouble = Math.Round(randomDouble, 2);
        array[i] += randomDouble;
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Min(double[] array)
{
    double min = array[0];
    for(int i = 0; i<array.Length; i++)
        if(array[i]<min) 
            min = array[i];
    return min;
}
double Max(double[] array)
{
    double max = array[0];
    for(int i = 0; i<array.Length; i++)
        if(array[i]>max) 
            max = array[i];
    return max;
}

Console.Write("Input a number: "); 
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: "); 
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: "); 
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine($"The max number is {Max(myArray)}");
Console.WriteLine($"The min number is {Min(myArray)}"); 

double dif = Max(myArray) - Min(myArray);
dif = Math.Round(dif, 2);
Console.WriteLine($"The different between min and max element in array is {dif}");
