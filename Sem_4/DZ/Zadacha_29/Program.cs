Console.WriteLine("Задача 29");
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
char[] array = new char[8];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToChar(rnd.Next('a', 'a' + 27));
    Console.Write("{0} ", array[i]);
}