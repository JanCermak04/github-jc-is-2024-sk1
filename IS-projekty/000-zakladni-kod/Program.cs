using System;

class Program
{
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
            Console.WriteLine("***** Výpis řady čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******** Jan Čermák ********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            // Add your functionality here (e.g., display a series of numbers)

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }
    }
}
 


    




// toto je jednořádkový komentář

/* toto je
víceřádkový
komentář
 */











