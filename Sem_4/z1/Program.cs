// See https://aka.ms/new-console-template for more information
Console.WriteLine("DZ_Sem_3_Zadacha_19");

bool IsPaliandrome(int number)
{
    string strnumber = number.ToString();
    if (strnumber[0]== strnumber[4] && strnumber[1]== strnumber[3] )
    {
        return true;
    }

    return false;
}

Console.Write("Vvedite 5 znachnoye chislo: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number <= 9999 || number>=100000)
{
    Console.WriteLine("Ne to");
    return;   
}

bool isPaliandrome = IsPaliandrome(number);
Console.WriteLine(isPaliandrome);