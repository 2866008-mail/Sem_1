// Дни недели
Console.Write("Введите № дня недели: ");
int x= Convert.ToInt32(Console.ReadLine());
if(x<1|x>7)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (x==1) Console.WriteLine("Понедельник");
    if (x==2) Console.WriteLine("Вторник");
    if (x==3) Console.WriteLine("Среда");
    if (x==4) Console.WriteLine("Четверг");
    if (x==5) Console.WriteLine("Пятница");
    if (x==6) Console.WriteLine("Суббота");
    if (x==7) Console.WriteLine("Воскресенье");
}