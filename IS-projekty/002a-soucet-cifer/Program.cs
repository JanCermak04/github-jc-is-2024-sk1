using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "a";

        while (again.Equals("a", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***** ciferný součet a součin *****");
            Console.WriteLine("***********************************");
            Console.WriteLine("************ Jan Čermák ***********");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            int suma = 0;
            int multi = 1;
            int numberBackup = number;
            int digit;

            // Pracujeme s absolutní hodnotou čísla
            number = Math.Abs(number);

            // Smyčka pro extrakci cifer
            while (number > 0)
            {
                digit = number % 10; // Získání poslední cifry
                number /= 10; // Odstranění poslední cifry
                suma += digit; // Přičtení k součtu
                multi *= digit; // Násobení pro součin
            }

            Console.WriteLine();
            Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, multi);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A, jinak stiskněte jinou klávesu pro ukončení:");
            again = Console.ReadLine();
        }
    }
}

