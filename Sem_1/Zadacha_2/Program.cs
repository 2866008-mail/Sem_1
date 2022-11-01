// Напишите программу, которая на вход получает два целых числа и проверяет является ли первое число квадратом второго

Console.Write("Введите число 1 = ");
        int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 = ");
        int numberB = Convert.ToInt32(Console.ReadLine());

        if (numberA == numberB * numberB)
        {
            Console.WriteLine($"Правда: число А={numberA} является квадратом числа В = {numberB} ");
        }
        else
        {
            Console.WriteLine($"Лож: число А={numberA} не является квадратом числа В = {numberB} ");
        }