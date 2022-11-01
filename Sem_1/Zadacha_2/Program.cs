// Напишите программу, которая на вход получает два целых числа и проверяет является ли первое число квадратом второго

console.writeline("Введите число 1 = ");
        int numberA = convert.toint32(console.readline());
        console.writeline("Введите число 2 = ");
        int numberB = convert.toint32(console.readline());

        if (numberA == numberB * numberB)
        {
            console.writeline($"Правда: число А={numberA} является квадратом числа В = {numberB} ");
        }
        else
        {
            console.writeline($"Лож: число А={numberA} не является квадратом числа В = {numberB} ");
        }