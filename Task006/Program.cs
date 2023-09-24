// задача 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int MaxDidgit(int num)
{
    int firstDidgit = num / 10;
    int secondDidgit = num % 10;
    return firstDidgit > secondDidgit ? firstDidgit : secondDidgit;
}


int number = new Random().Next(10, 99 + 1); // 99+1 ьщжно просто 100
Console.WriteLine($"Случайное число из отрезка -> {number}");

// int firstDidgit = number /10;
// int secondDidgit = number %10;

// // if(firstDidgit>secondDidgit) Console.WriteLine($"Наибольшее цифру число-> {firstDidgit}");
// // else Console.WriteLine($"Наибольшее цифру число-> {secondDidgit}");

// int maxDidgit = firstDidgit>secondDidgit ? firstDidgit : secondDidgit;
// Console.WriteLine($"Наибольшее цифру число ter-> {maxDidgit}");

int maxDidgit = MaxDidgit(number);
Console.WriteLine($"Наибольшее цифру число ter-> {maxDidgit}");

int maxDidgit1 = MaxDidgit(35);
Console.WriteLine($"Наибольшее цифру число ter-> {maxDidgit1}");