// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число = ");
int num = int.Parse(Console.ReadLine());

string str = num.ToString();
int[] array = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     array[i] = int.Parse(str[i].ToString());
}

if(str.Length == 5 && array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Палиндром!");
}
else
{
    Console.WriteLine("Не палиндром!");
}

if(str.Length != 5)
{
    Console.WriteLine("ПЯТИЗНАЧНОЕ!");
}