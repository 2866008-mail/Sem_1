// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nayti sum chisel ot '1' do 'N' ");

int SumN(int num) 
{
  int sum=0;
 /* int tempnum =1;

  while(tempnum <= num)
  {
    sum = sum+tempnum;
    tempnum = tempnum +1;
  }
  */
  for(int i=1; i<=num; i++)
  {
    sum=sum+i;
  }
  return sum;
}

Console.Write("Vvedite chislo: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum =SumN(num);
Console.WriteLine(sum);



