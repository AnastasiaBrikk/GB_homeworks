// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input a number of elements: ");
int numberElements = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i<numberElements; i++)
{
    Console.Write("Input numbers: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number>0) count++;
}

Console.WriteLine(count);
*/


//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double X(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    
    return x;
}

double Y(double k1, double b1, double x)
{
    double y=k1*x + b1;
    return y;
}
Console.Write("Input a value of k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value of b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value of k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value of b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1==k2 && b1==b2) 
{
    Console.WriteLine("Lines are merge");
}
else 
{
    if(k1 == k2) Console.WriteLine("Lines are parallel");
    else 
    {
        double x = X(k1,b1,k2,b2);
        Console.WriteLine($"The intersection point of the lines is [{x},{Y(k1,b1,x)}]");
    }
}
