// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.Write("Input a five-digit integer number:  ");
int number = Convert.ToInt32(Console.ReadLine());
bool Palindrom(int num)
{
    if(num % 10 == num / 10000)
    {
        int newNum = num % 10000;
        newNum = newNum / 10;
        if(newNum %10 == newNum /100) return true;
        else return false;
    }
    else return false;
}
if(number>= 10000 && number< 100000)
{
    bool result = Palindrom(number);
    Console.WriteLine(result);
}
else Console.WriteLine("Incorrect number!");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*Console.Write("Input Xa: ");
double Xa= Convert.ToDouble(Console.ReadLine());
Console.Write("Input Ya: ");
double Ya= Convert.ToDouble(Console.ReadLine());
Console.Write("Input Za: ");
double Za= Convert.ToDouble(Console.ReadLine());    
Console.Write("Input Xb: ");
double Xb= Convert.ToDouble(Console.ReadLine());
Console.Write("Input Yb: ");
double Yb= Convert.ToDouble(Console.ReadLine());
Console.Write("Input Zb: ");
double Zb= Convert.ToDouble(Console.ReadLine());
double Katet1(double Xa, double Ya, double Xb, double Yb)
{
    double quad1 = Math.Pow(Xa-Xb, 2);
    double quad2 = Math.Pow(Ya-Yb, 2);
    double katet = Math.Sqrt(quad1+quad2);
    return katet;
}
double katet1 = Katet1(Xa, Ya, Xb, Yb);
double katet2 = Za - Zb;
double result = Math.Sqrt(Math.Pow(katet1,2) + Math.Pow(katet2, 2));
Console.WriteLine($"The distance between points is {Math.Round(result, 2)}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0)
{
    for(int i=1; i<=number; i++)
    {
        double cubed = Math.Pow(i, 3);
        Console.WriteLine($"{i}*{i}*{i} = {cubed}");
    }
}
else Console.WriteLine("Error! Incorrect number.");
*/ 

