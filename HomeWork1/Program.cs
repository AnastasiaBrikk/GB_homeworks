//ДЗ 1

//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1>n2)
    Console.WriteLine($"Number {n1} is more than {n2}");
else
    Console.WriteLine($"Number {n2} is more than {n1}");
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if(n2>n1)
    max = n2;
    if(n2>n3)
        Console.WriteLine($"Number {n2} is the greatest");
else
    if(n3>n1)
    {
        Console.WriteLine($"Number {n3} is the greatest");
    }
    else
        Console.WriteLine($"Number {n1} is the greatest");
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n%2==0)
    Console.WriteLine($"Number {n} is an even integer");
else
    Console.WriteLine($"Number {n} is not an even integer");
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
int step = 2;
while (current <= number)
{
    Console.Write(current + " ");
    current = current + step;
}
*/
