﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a = int.Parse(Console.ReadLine());
int i = 2;
while (i<=a){
    if (i%2==0) Console.WriteLine (i);
    i++;
}