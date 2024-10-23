using System;
using System.Data; //genarator nahodnych čísel od do a kolik


class Program {
    static void Main()
    {
        string again = "a";

        // Main loop for repeating the program
        while (again.ToLower() == "a")
        {
            // Clear the console screen
            Console.Clear();
            
            // Display the program header
            Console.WriteLine("****************************");
            Console.WriteLine(" generování náhodných čísel ");
            Console.WriteLine("****************************");
            Console.WriteLine("******** Jan Čermák ********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            // Add your functionality here (e.g., display a series of numbers)


             Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("zadané hodnoty");
            Console.WriteLine("počet čísel {0}, dolní mez {1}, horní mez {2}",n, dm, hm);
            Console.WriteLine("=================================");
            Console.WriteLine();

            //deklarace pole - skrze hranate zavorky a int jedno dvoj ci troj rozmerne//

            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]); 
            }



            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }
    }
}