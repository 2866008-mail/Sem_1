// Напишите программу, которая на вход принимает число а на выход показывает все целые числа в диапозоне от -N до N
Console.Write("Введите число N: ");
int n=Convert.ToInt32(Console.ReadLine());
int xn=n*-1;
while(xn<=n)
{
Console.WriteLine(xn);
xn=xn+1;
}

