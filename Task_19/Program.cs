// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number!.Length > 5) Console.WriteLine("Неверное число - ошибка");
if (number!.Length < 5) Console.WriteLine("Неверное число - ошибка");
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine("Данное число - палиндром.");
  }
  else Console.WriteLine("Данное число не палиндром.");
