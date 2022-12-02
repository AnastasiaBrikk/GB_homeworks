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
/*
int X(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1)/(k1 - k2);
    
    return x;
}

int Y(int k1, int b1, int x)
{
    int y=k1*x + b1;
    return y;
}
Console.Write("Input a value of k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value of b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value of k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value of b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if(k1==k2 && b1==b2) 
{
    Console.WriteLine("Lines are merge");
}
else 
{
    if(k1 == k2) Console.WriteLine("Lines are parallel");
    else 
    {
        int x = X(k1,b1,k2,b2);
        Console.WriteLine($"The intersection point of the lines is [{x},{Y(k1,b1,x)}]");
    }
}
*/