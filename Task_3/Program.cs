// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число = ");
int N = int.Parse(Console.ReadLine());
int num = 1;

while(num <= N)
{
    Console.Write(Math.Pow(num, 3) +" ");
    num++;
}
