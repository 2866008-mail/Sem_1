// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
{
 
        int a, b, c;
Console.WriteLine("Введите 3 числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());

        c = Convert.ToInt32(Console.ReadLine());
 
         if (a > b && a > c)
                    Console.WriteLine("Nubmer Max = " + a); 
                else if (b > c)
                    Console.WriteLine("Number Max = " + b); 
                else
                    Console.WriteLine("Number Max = " + c); 
            
            Console.ReadLine();
 }
