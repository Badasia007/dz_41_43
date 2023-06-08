//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значение b1: ");
double b1 =  double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 =  double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 =  double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 =  double.Parse(Console.ReadLine());
double x = IntersectionPointX(b1, k1, b2, k2);
double y = IntersectionPointY(x, b2, k2);

double IntersectionPointX (double b1, double k1, double b2, double k2){
    double result1  = Math.Round((b2 - b1) / (k1 - k2), 2);
    double result2 = k2 * result1 + b2;
    return result1;
} 

double IntersectionPointY (double x, double b2, double k2){
    double result2 = Math.Round(( k2 * x + b2), 2);
    return result2;
} 

if (x == y){
Console.WriteLine("Прямые совпадают!");
}
else{
Console.WriteLine("Прямые паралельны!");
}

Console.WriteLine($"Точка пересечения 2 прямых имеет координаты ({x} ; {y})");