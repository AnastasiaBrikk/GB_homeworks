//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*Console.Write("Input a first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int B = Convert.ToInt32(Console.ReadLine());
int newA =  A;
if(B<0) B = Math.Abs(B);
for(int count=1; count<B; count++)
{
        newA *= A;
}

Console.WriteLine($"Number {A} in a power of {B} is {newA}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int Sum(int number)
{
        if(number<0) number = Math.Abs(number);
                int sum = 0;
                while(number > 0)
                {
                        sum += number%10;
                        number = number/10;
                }
        return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum digits of number {num} is {Sum(num)}");
*/

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


/*int[] FillArray(int size)
{
        int[] array = new int[size];
        for(int i=0; i<size; i++)
        {
                array[i] = Convert.ToInt32(Console.ReadLine());
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

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a random numbers: ");
int[] UserArray= FillArray(size);
ShowArray(UserArray);
*/
