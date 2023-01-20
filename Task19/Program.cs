Console.WriteLine("Узнаем, является ли число палиндромом");
Console.WriteLine("Введите целое пятизначное число N");
if(!int.TryParse(Console.ReadLine(), out int N) || N < 10000 || N > 99999)
{
    Console.WriteLine("Введено неверное число");
}
bool CheckPalindrome(int N)
{
    int firstDigit = N/10000;
    int secondDigit = ((N/1000) % 10);
    int fourDigit = ((N/10) % 10);
    int fiveDigit = (N % 10);
    if (firstDigit == fiveDigit && secondDigit == fourDigit)
    {
    return true;
    }
    else
    return false; 
}
if (CheckPalindrome(N))
    Console.WriteLine("It is palindrome");
else
    Console.WriteLine("It is not palindrome");