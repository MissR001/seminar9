/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/



Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);
void NaturalNumbers(int num)
/* проверка для отрицательных и положительных
if(number1 < 0 || number2 < 0)
{
Console.WriteLine("Incorrect numbers");
return;
}
*/
{
    if(num == 0) return;
     Console.Write($"{num}");
     NaturalNumbers(num - 1);
   
}




/* еще способ

Console.Write("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNumbers(number, count);


void NaturalNumbers(int num, int count)
{
    if (count > num) return;
   
        NaturalNumbers(num, count + 1);
        Console.Write(count + " ");
    
}
*/