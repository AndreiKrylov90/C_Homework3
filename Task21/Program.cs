Console.WriteLine("Ищем расстояние между точками в 3D");
Console.WriteLine("Введите координату x для точки 1");
if(!int.TryParse(Console.ReadLine(), out int x1))
{
    Console.WriteLine("Введено нецелое число");
}
Console.WriteLine("Введите координату y для точки 1");
if(!int.TryParse(Console.ReadLine(), out int y1))
{
    Console.WriteLine("Введено нецелое число");
}Console.WriteLine("Введите координату z для точки 1");
if(!int.TryParse(Console.ReadLine(), out int z1))
{
    Console.WriteLine("Введено нецелое число");
}Console.WriteLine("Введите координату x для точки 2");
if(!int.TryParse(Console.ReadLine(), out int x2))
{
    Console.WriteLine("Введено нецелое число");
}Console.WriteLine("Введите координату y для точки 2");
if(!int.TryParse(Console.ReadLine(), out int y2))
{
    Console.WriteLine("Введено нецелое число");
}Console.WriteLine("Введите координату z для точки 2");
if(!int.TryParse(Console.ReadLine(), out int z2))
{
    Console.WriteLine("Введено нецелое число");
}
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return result;
}
double S = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками = " + S.ToString("#.##"));