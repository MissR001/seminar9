/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


/* задача с семинара для образца
Console.WriteLine("Input number 1");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int n = Convert.ToInt32(Console.ReadLine());


void NaturalNumbersRange (int m, int n)
{
    if(m > n)
    {
    Console.Write($"{m}");
    NaturalNumbersRange(m-1,n);
    }
    else if (m < n)
    {
        Console.Write($"{m}");
         NaturalNumbersRange(m+1,n);
    }

    else Console.Write($"{m}");
}


Console.WriteLine("Input number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int number2 = Convert.ToInt32(Console.ReadLine());


// проверка для отрицательных и положительных
if(number1 < 0 || number2 < 0)
{
Console.WriteLine("Incorrect numbers");
return;
}
//

NaturalNumbersRange(number1, number2);
*/


Console.WriteLine("Input number 1");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int n = Convert.ToInt32(Console.ReadLine());

SumMtoN(m, n);

void SumMtoN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMtoN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}


