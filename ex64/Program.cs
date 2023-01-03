// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
string? entered_number = Console.ReadLine();
int number = Convert.ToInt32(entered_number);
for (int value = 1; value <= number; value++)

    {
        Console.Write(value + " ");  
    }
