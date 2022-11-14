

using System;

//1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



static void Main(int a, int b)
{
    int i = 0;
    int result = 1;

    while (i < b)
    {
        i++;
        result *= a;
        Console.WriteLine("{0} в степени {1} равно {2}", a, i, result);
    }
    Console.ReadLine();
}


Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Main(a, b);


//2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
static void Number(int value)
{
    int result = 0;
    while (value > 0)
    {
        result += value % 10;
        value /= 10;
    }

    Console.WriteLine($"Сумма чисел A равно: {result}");
}



Console.WriteLine("Введите число A: ");
int myValue = Convert.ToInt32(Console.ReadLine());

Number(myValue);
*/

//3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

class Program
{
    public static void Main(string[] args)
    {
        int enterNumber = 8;

        int[] array = new int[enterNumber];

        for (int i = 0; i < enterNumber; i++)
        {
            array[i] = new Random().Next(enterNumber + 1);

        }

        //Вариант вывода вне цикла:
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
}
*/