// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nayti Factorial ");

int GetFactorial (int num)
 {
      int res=1;
    
      for (int i=1; i<=num; i++)
      {
        res=res*i;
        Console.WriteLine($"Result {i} raven {res}");
      }      
      return res;
 }
Console.Write("Vvedite chislo: ");
int num=int.Parse(Console.ReadLine());
Console.WriteLine($"Prinimaem {num}");
Console.WriteLine($"Prinimaem {GetFactorial(num)}");

