﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The second Number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third Number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2 && number1 > number3){
        Console.WriteLine(number1);
    }
   else if(number2 > number1 && number2 > number3) {
        Console.WriteLine(number2);
    }
    else{
        Console.WriteLine(number3);
    }