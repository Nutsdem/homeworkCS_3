// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zb");
int zb = int.Parse(Console.ReadLine());

double getDistanse(int xaLoc, int yaLoc, int zaLoc, int xbLoc, int ybLoc, int zbLoc)
{
    double Dist = Math.Sqrt(Math.Pow((xbLoc - xaLoc), 2) + Math.Pow((ybLoc - yaLoc), 2) + Math.Pow((zbLoc - zaLoc), 2));
    return Dist;
}

Console.WriteLine(getDistanse(xa, ya, za, xb, yb, zb));
