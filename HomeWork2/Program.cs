// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*int SecondDigit(int number)
{
    number = number / 10 % 10;
    return number;
}
Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(number);
Console.WriteLine(result);
*/

// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int numero = num;
int ThirdDigit(int number)
{
    int result = number%10;
    return result;
}
if(numero>99)
{
    while(numero >= 1000)
    {
        numero = numero / 10;
    }
    int third = ThirdDigit(numero);
    Console.WriteLine($"The third digit of {num} is {third}");
}
else
{
    Console.WriteLine("No third digit in the number");
}
*/

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*bool Week(int number)
{
    if(number>6)
        return true;
    else
        return false;
}
Console.WriteLine("Введите число от 1 до 7 включительно: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 1 || num >7)
    {
        Console.WriteLine("Введено неподходящее число");
    }
else
    {
        bool result = Week(num);
        Console.WriteLine(result);
    }
*/
