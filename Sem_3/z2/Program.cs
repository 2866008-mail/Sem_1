// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача на нахождения растояния между двумя координатами");


// Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)) формула нахождения растояния между точками

Double Sdistans(int x1, int y1, int x2, int y2) 
{
 Double distans= (int)Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
 return distans;
}

Console.WriteLine("x1:");
int x1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y1:");
int y1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("x2:");
int x2 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y2:");
int y2 =Convert.ToInt32(Console.ReadLine());

Double distans=Sdistans(x1,y1,x2,y2);

Console.WriteLine(distans);
