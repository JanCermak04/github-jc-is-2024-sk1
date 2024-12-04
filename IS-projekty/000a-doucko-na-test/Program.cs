Console.WriteLine("****************************");
Console.WriteLine("***** Výpis řady čísel *****");
Console.WriteLine("****************************");
Console.WriteLine("******** Jan Čermák ********");
Console.WriteLine("****************************");
Console.WriteLine();

int dm = 0;
int hm = 10;
int pocet_prvku = 15;
int[] my = new int[pocet_prvku];

Random generator = new Random();
for (int i = 0; i < pocet_prvku; i++)
{
    my[i] = generator.Next(dm, hm);
}
Console.WriteLine("Vygenerovana cisla:");
for (int i = 0; i < pocet_prvku; i++)
{
    Console.Write(my[i] + " ");
}

Console.WriteLine("--------------------------------------------------");
int min = my [0];
int max = my [0];
for (int i = 0; i < pocet_prvku; i++)
{
    if (min > my [i])
    {
        min = my [i];
    }
    if (max < my [i])
    {
        max = my [i];
    }
}
Console.WriteLine();
// Vypis všechny pozice minima
Console.WriteLine("Nejmensi cislo je " + min + " na pozicich:");
for (int i = 0; i < pocet_prvku; i++)
{
    if (my[i] == min)
    {
        Console.Write((i + 1) + " ");
    }
}
Console.WriteLine(); // Nový řádek

// Vypis všechny pozice maxima
Console.WriteLine("Nejvetsi cislo je " + max + " na pozicich:");
for (int i = 0; i < pocet_prvku; i++)
{
    if (my[i] == max)
    {
        Console.Write((i + 1) + " ");
    }
}

Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();


int dva = second.max 
Console.WriteLine("druhé největší číslo:" second.max );



Console.ReadKey();