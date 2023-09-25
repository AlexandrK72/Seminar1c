
// using Internal;

// Math.Pow(4,6)
// Math.Sqrt

// doble d = 5.09999984343;
// doble dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);

// Задача 21: Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21




double Pifagor(int x1, int x2, int y1, int y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;

}

Console.WriteLine("Введите координаты точек");
Console.Write("x1:");

int x1Cordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("x2:");

int x2Cordinate = Convert.ToInt32(Console.ReadLine());


Console.Write("y1:");
int y1Cordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("y2:");
int y2Cordinate = Convert.ToInt32(Console.ReadLine());

double res = Pifagor(x1Cordinate, x2Cordinate, y1Cordinate, y2Cordinate);


Console.WriteLine($"{res}");