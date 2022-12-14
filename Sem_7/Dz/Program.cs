// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Задача 47");
//Задача 47. Запросите от пользователя размерности двумерного массива. 
/*Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой.
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

Console.WriteLine($"Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(-999, 999);
        }
    }
}

void WriteArray (double[,] array){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 3);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задача 50");
//Задача 50. Напишите программу, которая будет принимать от пользователя позицию (M, N)
/* двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
Если такой позиции в массиве нет, то сообщить об этом пользователю. 
Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.*/

Console.WriteLine($"Задайте координаты элемента m * n,  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.");
Console.Write("Введите mn (Пример - 99 или 17) : ");
string mn = Console.ReadLine();

int first_element = Convert.ToInt32(char.GetNumericValue(mn[0]));

int second_element = Convert.ToInt32(char.GetNumericValue(mn[1]));


check_element_position(array, first_element,second_element);

void check_element_position(double[,] array, int el1, int el2)
{
    int el1_real = array.GetLength(0);
    int el2_real = array.GetLength(1);
    Console.WriteLine($"{el1_real} {el2_real} {el1} {el2}");
    if ( el1 > el1_real || el2 > el2_real) Console.WriteLine(mn + " - такого числа в массиве нет");
    else
    {
        if (el1 == 0) el1 = 1;
        if (el2 == 0) el2 = 1;
        Console.WriteLine(array[el1-1, el2-1]);
    }
}


Console.WriteLine("Задача 52");
//Задача 52. Запросите от пользователя размерности двумерного массива. 
/*Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] arrayint = new int[m, n];
CreateArrayInteger(arrayint);
WriteArrayInt(arrayint);
SredneeArrayInt(arrayint);
SredneeArrayIntKolonka(arrayint);


void CreateArrayInteger(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-99, 99);
        }
    }
}

void WriteArrayInt (int[,] array){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SredneeArrayInt (int[,] array)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            temp += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое строки " + temp / n);
    }
    Console.WriteLine();
}

void SredneeArrayIntKolonka (int[,] array)
{
    int []sum=new int [n];
    for (int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {
            sum[i] += array[j, i];
        }
    }

    foreach (double elem in sum)
    {
                
        Console.WriteLine(elem/m);
    }
}