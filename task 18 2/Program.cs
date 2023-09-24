// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string QuarterTwoCoords(int quadr)
{
    if(quadr==1) return "x > 0 && y > 0";
    if(quadr==2) return "x < 0 && y > 0";
    if(quadr==3) return "x < 0 && y < 0";
    if(quadr==4) return "x > 0 && y < 0";
    return null;
   
    // if (x > 0 && y > 0) return 1;
    // if (x < 0 && y > 0) return 2;
    // if (x < 0 && y < 0) return 3;
    // if (x > 0 && y < 0) return 4;
    // return 0;
}


Console.WriteLine("Введите номер области");
Console.Write("область:");

int quarter = Convert.ToInt32(Console.ReadLine());

string result = QuarterTwoCoords(quarter);

Console.WriteLine((result != null) ? result : "user did not input quater number");