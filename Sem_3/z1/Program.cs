// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 1");

/* 
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

// <Возвращающийся тип даннных> <наименование метода> (переменные ){тело метода}

 // Знак  &&  обозначает и 

// Метод получения четверти на плоскости
int GetPointArea(int cordX, int cordY) // void - если не хотим чтобы метод что либо возврощал
{
   int numberArea = 0;
   if (cordX > 0 && cordY > 0)                                   
   {
    numberArea=1;
   }

   if (cordX < 0 && cordY > 0)
   {
    numberArea=2;
   }
   if (cordX < 0 && cordY < 0)
   {
    numberArea=3;
   }
   if (cordX > 0 && cordY < 0)
   {
    numberArea=4;
   }
 return numberArea;


}

Console.WriteLine("x:");
int x =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y:");
int y =Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x,y);

Console.WriteLine(numberArea);
