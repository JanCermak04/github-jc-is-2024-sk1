﻿using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("***** příprava na test *****");
        Console.WriteLine("****************************");
        Console.WriteLine("******** Jan Čermák ********");
        Console.WriteLine("****************************");
        Console.WriteLine();

        int hm = 10;
        int dm = 0;
        int pocet_prvku = 15;

        int[] MY = new int[pocet_prvku];

        Random generator = new Random();
        for (int i = 0; i < pocet_prvku; i++)
        {
            MY[i] = generator.Next(dm, hm);
        }

        Console.WriteLine("Vygenerovana cisla: ");
        foreach (int num in MY)
            Console.Write(num + " ");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();


                // Min and Max
        int min = MY[0], max = MY[0];
        for (int i = 0; i < pocet_prvku; i++)
        {
            if (min > MY[i]) min = MY[i];
            if (max < MY[i]) max = MY[i];
        }

        Console.WriteLine("Nejmensi cislo je " + min + " na pozicich:");
        for (int i = 0; i < pocet_prvku; i++)
        {
            if (MY[i] == min)
                Console.Write((i + 1) + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Nejvetsi cislo je " + max + " na pozicich:");
        for (int i = 0; i < pocet_prvku; i++)
        {
            if (MY[i] == max)
                Console.Write((i + 1) + " ");
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();


        Stopwatch stopwatch = new Stopwatch();

        // CombSort
        int[] MYCombSort = (int[])MY.Clone();
        stopwatch.Start();
        CombSort(MYCombSort);
        stopwatch.Stop();
        Console.WriteLine($"CombSort trvá: {stopwatch.ElapsedTicks} tiky ({stopwatch.ElapsedTicks * 1000.0 / Stopwatch.Frequency:F6} ms)");

        // InsertionSort
        int[] MYInsertionSort = (int[])MY.Clone();
        stopwatch.Restart();
        InsertionSort(MYInsertionSort);
        stopwatch.Stop();
        Console.WriteLine($"InsertionSort trvá: {stopwatch.ElapsedTicks} tiky ({stopwatch.ElapsedTicks * 1000.0 / Stopwatch.Frequency:F6} ms)");

    
    
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        // BubbleSort (lokální funkce)
        void BubbleSort(int[] MY)
        {
            int temp;
            for (int i = 0; i < MY.Length - 1; i++)
            {
                for (int j = 0; j < MY.Length - i - 1; j++)
                {
                    if (MY[j] > MY[j + 1])
                    {
                        temp = MY[j];
                        MY[j] = MY[j + 1];
                        MY[j + 1] = temp;
                    }
                }
            }
        }
        // InsertionSort (lokální funkce)
        void InsertionSort(int[] MY)
        {
            for (int i = 1; i < MY.Length; i++)
            {
                int j = i;
                int temp = MY[j];
                while (j > 0 && MY[j - 1] > temp)
                {
                    MY[j] = MY[j - 1];
                    j--;
                }
                MY[j] = temp;
            }
        }

        // CombSort (lokální funkce)
        void CombSort(int[] MY)
        {
            int gap = MY.Length;
            bool swapped = true;

            while (gap != 1 || swapped)
            {
                gap = (int)(gap / 1.3);
                if (gap < 1) gap = 1;

                swapped = false;
                for (int i = 0; i + gap < MY.Length; i++)
                {
                    if (MY[i] > MY[i + gap])
                    {
                        int temp = MY[i];
                        MY[i] = MY[i + gap];
                        MY[i + gap] = temp;
                        swapped = true;
                    }
                }
            }
        }


        // Použití třídících funkcí
        BubbleSort(MY);
        Console.WriteLine("Seřazené pole (Bubble sort):");
        foreach (int num in MY)
            Console.Write(num + " ");
        Console.WriteLine();
        
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        InsertionSort(MY);
        Console.WriteLine("Seřazené pole (Insertion sort):");
        foreach (int num in MY)
            Console.Write(num + " ");
        Console.WriteLine();

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        CombSort(MY);
        Console.WriteLine("Seřazené pole (Comb sort):");
        foreach (int num in MY)
            Console.Write(num + " ");
        Console.WriteLine();

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();



       
       

int fourthLargest = -1; 
int sixthlargest = - 1;

// Použijeme LINQ k odstranění duplicit
var uniqueNumbers = MY.Distinct().ToArray(); // Odstraníme duplicity
CombSort(uniqueNumbers);
Array.Reverse(uniqueNumbers);

if (uniqueNumbers.Length >= 4)
{
    fourthLargest = uniqueNumbers[3]; // 4. největší číslo
    Console.WriteLine("Ctvrte nejvetsi cislo je: " + fourthLargest);
}
else
{
    Console.WriteLine("Pole nemá dostatečný počet unikátních prvků.");
}

if (uniqueNumbers.Length >= 6)
{
    sixthlargest = uniqueNumbers[5]; // 4. největší číslo
    Console.WriteLine("Šesté nejvetsi cislo je: " + sixthlargest);
}
else
{
    Console.WriteLine("Pole nemá dostatečný počet unikátních prvků.");
}

// Pokud existuje, můžete použít `fourthLargest` i později v kódu, například pro převod na binární soustavu.
if (fourthLargest != -1) 
{
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
}



Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
        // Výpočet průměru
        double sum = 0;
        foreach (int num in MY)
        {
            sum += num;
        }

        double average = sum / MY.Length;

        int wholePart = (int)average;
        double remainder = average - wholePart;

        Console.WriteLine("Prumer generovanych cisel: ");
        Console.WriteLine("Celočíselná část: " + wholePart);
        Console.WriteLine("Zbytek: " + remainder);

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
    


 
         // Zadejte počet členů Fibonacciho posloupnosti
        Console.Write("Zadejte počet členů Fibonacciho posloupnosti: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Prosím, zadejte platné kladné celé číslo.");
        }

        // Výpočet Fibonacciho posloupnosti a jejího součtu
        int fibonacciSum = 0; // Součet členů posloupnosti
        Console.WriteLine("Fibonacciho posloupnost:");
        FibonacciIterative(n, out fibonacciSum);

        Console.WriteLine();
        Console.WriteLine("Součet prvků Fibonacciho posloupnosti je: " + fibonacciSum);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
         // Lokální funkce pro iterativní výpočet Fibonacciho posloupnosti
       
        void FibonacciIterative(int count, out int sum)
        {
            sum = 0;
            int a = 0, b = 1;

            for (int i = 0; i < count; i++)
            {
                Console.Write(a + " "); // Výpis aktuálního čísla
                sum += a;              // Přidání čísla do součtu
                int temp = a + b;
                a = b;
                b = temp;
            }
        }
    

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        // Define the initial number of elements in the sequence
int pocet_rady = 9;

// Function to generate an arithmetic sequence and calculate its sum
void GenerateArithmeticSequence(int start, int diff, int count)
{
    if (count <= 0)
    {
        Console.WriteLine("Počet prvků musí být kladné číslo.");
        return;
    }

    Console.WriteLine("Aritmetická posloupnost:");
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        int current = start + i * diff; // Arithmetic sequence formula
        Console.Write(current + " ");
        sum += current; // Add the current element to the sum
    }

    Console.WriteLine();
    Console.WriteLine("Součet aritmetické posloupnosti: " + sum);
}

// Ensure fourthLargest and sixthLargest are valid
if (uniqueNumbers.Length >= 6)
{
    
    int sixthLargest = uniqueNumbers[5];  // 6th largest unique number

    // Call the function with appropriate values
    GenerateArithmeticSequence(fourthLargest, sixthLargest, pocet_rady);
}
else
{
    Console.WriteLine("Pole nemá dostatečný počet unikátních prvků pro výpočet aritmetické posloupnosti.");
}


        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

       Console.WriteLine("Kosoctverec:");
        int height = 5; // Výška obdélníku
        int width = 10; // Šířka obdélníku

        for (int i = 0; i < height; i++)
        {
            // Přidání odsazení pro kosý efekt
            Console.Write(new string(' ', i));

            if (i == 0 || i == height - 1)
            {
                // Horní a dolní vodorovná strana (2 řádky)
                Console.WriteLine(new string('*', width));
                Console.Write(new string(' ', i)); // Přidání odsazení pro druhý řádek
                Console.WriteLine(new string('*', width));
            }
            else
            {
                // Boční svislé strany (prázdný vnitřek)
                Console.WriteLine("*" + new string(' ', width - 2) + "*");
            }
        }


    Console.WriteLine("šipka");
        int vyska = wholePart; // Výška šipky

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

        
        
        
         Console.WriteLine("Šipka dolů");


        int vyskaSipky = wholePart; // Výška trojúhelníkové části šipky
        int vyskaTelo = wholePart;  // Výška těla šipky

        // Tělo šipky (svislý pruh s prázdným vnitřkem)
        for (int i = 0; i < vyskaTelo; i++)
        {
            Console.Write(new string(' ', vyskaSipky - 2)); // Odsazení
            Console.WriteLine("* *"); // Šířka těla s prázdným vnitřkem
        }

        // Dolní část šipky (trojúhelník směřující dolů)
        for (int i = vyskaSipky - 1; i >= 0; i--)
        {
            Console.Write(new string(' ', vyskaSipky - i - 1)); // Odsazení
            if (i == 0)
            {
                Console.WriteLine("*"); // Spodní špička
            }
            else
            {
                Console.Write("*"); // Levý okraj
                Console.Write(new string(' ', 2 * i - 1)); // Vnitřní mezera
                Console.WriteLine("*"); // Pravý okraj
            }
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

// ctverec s uhloprickou //


        int size = 10; // Výška čtverce

        // Horní hrana
        for (int i = 0; i < size; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        // Vnitřek čtverce
        for (int i = 1; i < size - 1; i++)
        {
            Console.Write("*"); // Levý okraj čtverce

            for (int j = 1; j < size - 1; j++)
            {
                if (j == i) // Podmínka pro uhlopříčku hvězdiček
                    Console.Write("*");
                else if (j > i) // Pravá strana od uhlopříčky
                    Console.Write("0");
                else
                    Console.Write(" "); // Mezera vlevo od uhlopříčky
            }

            Console.Write("*"); // Pravý okraj čtverce
            Console.WriteLine();
        }

        // Spodní hrana
        for (int i = 0; i < size; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();


            // Zajištění, že konzolové okno zůstane otevřené
            Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení programu...");
            Console.ReadKey();
        }
    }

