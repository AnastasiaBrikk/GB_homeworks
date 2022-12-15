// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    if(n > 0)
    {
        Console.Write(n + " ");
        ShowNumbers(n - 1);
    }

}

ShowNumbers(10);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ElementsSum(int m, int n)
{
    if (m < n) return ElementsSum(m + 1, n) + m;
    else if (n < m) return ElementsSum(m, n + 1) + n;
    else return m;
}
Console.WriteLine(ElementsSum(0, 0));
*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
/*
int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return A(m-1, 1);
    else
        return A(m - 1, A(m, n- 1));
}
Console.WriteLine(A(3, 2));
Console.WriteLine(A(2, 3));
*/