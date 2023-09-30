// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120




int Factorial(int num)
{

    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result = result * i; // sum +=i
        }

    }
    return result;
}


Console.WriteLine("Введте целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{

    Console.WriteLine("некорректный ввод");
    return;
}

int factorial = Factorial(number);

Console.WriteLine($"Произведение чисел от 1 до {number} = {Factorial(number)}");