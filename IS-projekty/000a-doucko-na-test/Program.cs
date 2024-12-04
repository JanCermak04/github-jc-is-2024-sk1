using System.IO.Compression;

Console.WriteLine("****************************");
Console.WriteLine("***** příprava na test *****");
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
//serazeni najit nejvetsi//
Array.Sort(my); // Seřadíme pole od nejmenšího po největší
for (int i = 0; i < my.Length; i++)
    {
        Console.Write(my[i] + " ");
    }


Console.WriteLine(); 


int fourthLargest = my[my.Length - 4]; // 4. největší číslo
int sixthLargest = my[my.Length - 6]; // 6. největší číslo

Console.WriteLine("Ctvrte nejvetsi cislo je: " + fourthLargest);
Console.WriteLine("Seste nejvetsi cislo je: " + sixthLargest);

Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
//binarni soustava čtvre cislo//

    uint originalFourthLargest = (uint)fourthLargest; // Původní hodnota
    uint[] myArray = new uint[32]; // Pole pro binární čísla
    uint zbytek;
    uint z;

    
    for(z=0; originalFourthLargest > 0; z++) {
        zbytek = originalFourthLargest % 2;
        originalFourthLargest = (originalFourthLargest - zbytek)/2;
        myArray[z] = zbytek;

    }

    Console.WriteLine("Čtvré největší číslo je v binární soustavě:");
    for(uint j=z-1; j>=0; j--) {
     Console.Write("{0}",myArray[j]);
    }

Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
//fibonacciho posloupnost//



Console.ReadKey();