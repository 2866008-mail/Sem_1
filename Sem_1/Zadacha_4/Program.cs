// See https://aka.ms/new-console-template for more information
Console.Write("Введите число N: ");
int n=Convert.ToInt32(Console.ReadLine());
int xn=n*-1;
while(xn<=n)
{
Console.WriteLine(xn);
xn=xn+1;
}

