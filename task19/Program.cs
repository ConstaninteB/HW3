// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// string array = Console.ReadLine(); 
// if (array.Length == 5)
// {
//     if (array [0]== array [4] && array [1] == array [3])
//     {
//         Console.WriteLine($"{array} -> да");
//     }
//     else
//     {
//         Console.WriteLine($"{array} -> нет");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное");
// }


 
        Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine()); 
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int rev1 = number / 10 % 10;
        int rev2 = number % 10;
  Console.WriteLine($"{num1} {num2} {rev1} {rev2}");
        
            if (number < 10000 && number > 99999){
            Console.WriteLine(number  + "  это не пятизначное число");
            }
            else if  (num1 == rev2 && num2 == rev1){
            Console.WriteLine(number + "  да, палиндром");
            }
            else{
            Console.WriteLine(number + "  нет, не палиндром");
            }
        