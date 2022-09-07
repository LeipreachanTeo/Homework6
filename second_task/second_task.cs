Console.WriteLine("Укажите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Укажите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Укажите число b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Укажите число k2: ");
double k2 = double.Parse(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают!!!");
}
else if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются!!!");
}
else
{
    double x = (b1 - b2)/ (k2 - k1);
    double y = ((k2 * b1)-(k1 * b2)) / (k2 - k1);
    Console.WriteLine($"Точка пересечения прямых : ({x};{y})");
}
