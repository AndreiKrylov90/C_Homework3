Console.WriteLine("Выводим кубы всех чисел от 1 до N");
Console.WriteLine("Введите целое число N");
if(!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
{
    Console.WriteLine("Введено нецелое или отрицательное число");
}

double Cube(int N)
{
    return N*N*N;
}
int i = 1;
while (i <= N)
    {
        Console.Write(Cube(i) + " ");
        i++;
    }