// Найти максимальное из 3 чисел

Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int C=Convert.ToInt32(Console.ReadLine());

int max=A;
if(B>max)
{
max=B;
}
if(C>max)
{
max=C;
}

Console.WriteLine($"Максимальное из 3 чисел : {max}");
Console.ReadKey();
