// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


bool MultipleTwonumbers(int num1, int num2, int num3)
{
    return num1 % num2 == 0 && num1 % num3 == 0;

}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = 7;
int secondNumber = 23;

bool result = MultipleTwonumbers(number, firstNumber, secondNumber);
Console.WriteLine(result ? $"{number}-> Да" : $"{number}-> Нет" );

// if (number % firstNumber == 0 && number % secondNumber ==0)
// {

//     Console.WriteLine($"{number} -> да");
// }
// else Console.WriteLine($"{number} -> нет");








// int RemaidenNumber(int num1, , int num3)
// {
//     return num1 % 7;
// }