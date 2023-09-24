// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


using System.Globalization;

Console.WriteLine("Введите число");
int na = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число второе");
int nb = Convert.ToInt32(Console.ReadLine());


int RemaidenNumber(int num1, int num2)
{
    return num1 % num2;
}
// if (na % nb == 0) 
// {
//     Console.WriteLine($"{na} -> кратно {nb}");
// }
// else Console.WriteLine($"{na} -> не кратно {nb}");

int remaidenNumber = RemaidenNumber(na, nb);
if (remaidenNumber == 0)
{
    Console.WriteLine($"{na} -> кратно {nb}");
}
else Console.WriteLine($"{na} -> не кратно {nb}");