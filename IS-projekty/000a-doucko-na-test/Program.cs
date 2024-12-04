using System.IO.Compression;

Console.WriteLine("****************************");
Console.WriteLine("***** příprava na test *****");
Console.WriteLine("****************************");
Console.WriteLine("******** Jan Čermák ********");
Console.WriteLine("****************************");
Console.WriteLine();
// po zadání domyslet //
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

        uint originalFourthLargest = (uint)fourthLargest;
        uint[] myArray = new uint[32];
        uint zbytek;
        uint z;

        for (z = 0; originalFourthLargest > 0; z++)
        {
            zbytek = originalFourthLargest % 2;
            originalFourthLargest /= 2;
            myArray[z] = zbytek;
        }

        Console.WriteLine("Čtvrté největší číslo v binární soustavě:");
        for (int j = (int)z - 1; j >= 0; j--)
        {
            Console.Write(myArray[j]);
        }

Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
//fibonacciho posloupnost//




// tvary šipky kosoctverec a presipaci hodiny 
     Console.WriteLine("Kosoctverec:");
        int sirka = 7; // Šířka kosodélníku
        for (int i = 0; i < sirka; i++)
        {
            Console.Write(new string(' ', sirka - i));
            Console.WriteLine(new string('*', 2 * i + 1));
        }
        for (int i = sirka - 2; i >= 0; i--)
        {
            Console.Write(new string(' ', sirka - i));
            Console.WriteLine(new string('*', 2 * i + 1));
        }

    Console.WriteLine("šipka");
        int vyska = 5; // Výška šipky

        // Horní část šipky (trojúhelník)
        for (int i = 0; i < vyska; i++)
        {
            Console.Write(new string(' ', vyska - i - 1)); // Odsazení
            Console.WriteLine(new string('*', 2 * i + 1)); // Počet hvězdiček
        }

        // Tělo šipky (svislý pruh)
        for (int i = 0; i < vyska; i++)
        {
            Console.Write(new string(' ', vyska - 1)); // Odsazení
            Console.WriteLine("*"); // Jedna hvězdička
        }

Console.ReadKey();