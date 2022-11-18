/*Задача №19
Напишите программу, которая  принимает на вход пятизначное число
и проверяет является ли оно палиандромом. 

void Palindrome(int number)
{
    if ((number / 10000) == (number % 10) && ((number / 1000) % 10) == ((number % 100) / 10))
    Console.WriteLine($"the number {number} is a palindrome");
    else Console.WriteLine($"the number {number} is not a palindrome");
}

Console.Write("Enter a five-digit number ");
int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 10000 && num <100000)
Palindrome(num);
    else Console.WriteLine("Enter the correct number");

Задача №21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве. 

double Line(int x1, int y1, int z1, int x2, int y2, int z2)
  {
    double lengthAB = Math.Round(Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1)), 2);
    return lengthAB;
  }

Console.WriteLine("Imput X coordinat of A:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Y coordinat of A:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Z coordinat of A:");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput X coordinat of B:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Y coordinat of B:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Z coordinat of B:");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Line(xA, yA, zA, xB, yB, zB);


Console.WriteLine($"Distanse AB is {dist} ");

Задача №23
Напишите программу, которая на вход принимает число N и выводит таблицу кубов чисел от 1 до N. 
*/
void Qurd(int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current * current;
        Console.Write($"{res}, ");
        current ++;
    }
    Console.WriteLine("\b\b.");
}
Console.WriteLine("Imput number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Qurd(number);
}
else Console.WriteLine("Imposible number!");
