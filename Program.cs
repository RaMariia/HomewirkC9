//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.WriteLine("Введите натуральное число больше 1:");
int num = Convert.ToInt32(Console.ReadLine());

   if (num < 1)
{
    Console.WriteLine("Введено не натуральное число");
}
void ShowNums(int num)
{
    if(num >0  ) ShowNums(num - 1); 
    Console.Write(num + " ");  
}
ShowNums(num);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*
Console.WriteLine("Введите число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numN = Convert.ToInt32(Console.ReadLine());

void SumOfNumbers (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    SumOfNumbers(numM, numN, sum);
}

SumOfNumbers(numM, numN, 0);
*/

//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
/*
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write(Akkerman(m, n)); 
*/






