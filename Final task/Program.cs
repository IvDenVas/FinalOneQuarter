﻿// Напишите программу, которая из имеющегося массива строк формирует массив из строк, доина которых меньше либо равна 3
// символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
int userInput = UserInput("Введите длину одномерного массива: ", "Ошибка ввода!");
string[] array = new string[userInput];
GetArray(array);
PrintArray(array);


int UserInput (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num > 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}

void GetArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new string(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}