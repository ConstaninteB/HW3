// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
string array = Console.ReadLine(); 
if (array.Length == 5)
{
    if (array [0]== array [4] && array [1] == array [3])
    {
        Console.WriteLine($"{array} -> да");
    }
    else
    {
        Console.WriteLine($"{array} -> нет");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}
