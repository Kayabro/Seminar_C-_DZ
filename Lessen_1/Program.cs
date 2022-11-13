// Написать программу которая принимает число и выдает его квадрат
Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine()!);

// int sqr = number * number;

// Console.WriteLine($"Квадрат числа {number } = {sqr}");


// Вариант 2
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number } = {sqr1}");
