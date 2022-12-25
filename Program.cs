/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*void FindNaturalNumbers (int N)
{
    if(N <= 0)
    {
        return;  
    }
    else
    {
       FindNaturalNumbers(N-1);
    }
     Console.Write(N +" ");
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
FindNaturalNumbers(N);*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*void FindInterval(int start, int finish)
{
    int sum = 0;
    
        if(start > finish)
        {
            FindInterval(start-1, finish);
            Console.Write(start +" ");   
        }
    else 
    {
        sum =  ((start + finish) / 2) * (finish - start + 1);
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
    }
}
Console.WriteLine("Введите начало промежутка");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец промежутка");
int finish = Convert.ToInt32(Console.ReadLine());
FindInterval(start,finish);*/
