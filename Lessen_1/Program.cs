﻿// Написать программу которая принимает число и выдает его квадрат
Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

Console.WriteLine($"Квадрат числа {number } = {sqr}");

