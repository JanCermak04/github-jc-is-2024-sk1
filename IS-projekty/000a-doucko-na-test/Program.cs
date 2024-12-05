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
Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
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
      int height = 5; // Výška obdélníku
        int width = 10; // Šířka obdélníku

        for (int i = 0; i < height; i++)
        {
            // Přidání odsazení pro kosý efekt
            Console.Write(new string(' ', i));

            // Vykreslení řádku obdélníku
            Console.WriteLine(new string('*', width));
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
            Console.Write(new string(' ', vyska - 2)); // Odsazení
            Console.WriteLine("* *"); // Jedna hvězdička
        }
        // ukončení šipky
        for (int i = 0; i < vyska - 4; i++)
        {
            Console.Write(new string(' ', vyska - 2)); // Odsazení
            Console.WriteLine("***"); // Jedna hvězdička
        }






        // přesípací hodiny //
        Console.WriteLine("Přesýpací hodiny:");

        int hight = 5; // Výška jedné poloviny přesýpacích hodin

// Horní část (prázdný trojúhelník)
for (int i = 0; i < hight; i++)
{
    Console.Write(new string(' ', i)); // Odsazení zleva

    // První a poslední řádek je plný
    if (i == 0)
    {
        Console.WriteLine(new string('*', (hight - i) * 2 - 1));
    }
    else
    {
        // Řádky s prázdným vnitřkem
        Console.Write("*"); // První hvězdička
        int mezery = (hight - i) * 2 - 3; // Počet mezer uvnitř
        if (mezery > 0)
        {
            Console.Write(new string(' ', mezery));
        }
        Console.WriteLine("*"); // Poslední hvězdička
    }
}

        // Spodní část (trojúhelník s nulami)
for (int i = hight - 1; i >= 0; i--)
{
    Console.Write(new string(' ', i)); // Odsazení zleva

    // První a poslední řádek je plný
    if (i == 0)
    {
        Console.WriteLine(new string('*', (hight - i) * 2 - 1));
    }
    else
    {
        // Řádky s nulami uvnitř
        Console.Write("*"); // První hvězdička
        int mezery = (hight - i) * 2 - 3; // Počet nul uvnitř
        if (mezery > 0)
        {
            Console.Write(new string('0', mezery));
        }
        Console.WriteLine("*"); // Poslední hvězdička
    }
}

Console.ReadKey();