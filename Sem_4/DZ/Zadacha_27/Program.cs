// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 27: ");
/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Для решения задания использование цикла for является обязательным условием
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число ");
string chislo = Console.ReadLine();
int summa = 0;
for (int i = 0; i < chislo.Length; i++)
{
    int chislo1 = Convert.ToInt32(Char.GetNumericValue(chislo[i]));
    summa += chislo1;
}
Console.WriteLine(summa);
