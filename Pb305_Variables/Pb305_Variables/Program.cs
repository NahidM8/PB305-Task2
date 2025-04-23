#region Task1
int number = 21;
if (number == 0)
    Console.WriteLine("eded 0 a beraberdir");
else
{
    if (number % 3 == 0)
        Console.WriteLine("eded 3 e bolunur");
    else
        Console.WriteLine("eded 3 e bolunmur");
}
#endregion
#region Task2
int number2 = 16;
if (number2 > 10 && number2 < 15)
    Console.WriteLine("eded 10 ve 15 arasindadir");
else
    Console.WriteLine("eded 10 ve 15 arasinda deyil");
#endregion
#region Task3
int n = 12;
if (n == 0)
    Console.WriteLine("eded 0 a beraberdir");
else
{
    if (n % 3 == 0 && n % 7 == 0)
        Console.WriteLine("eded 3 ve 7 e bolunur");
    else
        Console.WriteLine("eded 3 ve 7 e bolunmur");
}
#endregion