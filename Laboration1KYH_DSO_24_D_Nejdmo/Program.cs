using System;

class Program
{
    static void Main()
    {
        //Kod för att kunna ge input från konsolen. Kommentera i så fall bort hårdkodad textsträng nedan.
        //Console.Write("Skriv in siffror och bokstäver: ");
        //string input = Console.ReadLine();
      

        // Hårdkodad textsträng
       string input = "29535123p48723487597645723645";
       decimal totalSum = 0M;

        Console.WriteLine("Output för input: " + input);
        Console.WriteLine("\nMarkerade tal som börjar och slutar på samma siffra:");

        // Loopar igenom hela textsträngen
        for (int i = 0; i < input.Length; i++)
        {
            // Kollar om det är en siffra
            if (char.IsDigit(input[i]))
            {
                // Går igenom delsträngar från den aktuella positionen
                for (int j = i + 1; j < input.Length; j++)
                {
                    // Avbryter om det är något annat än en siffra
                    if (!char.IsDigit(input[j])) break;

                    // Kollar om start- och slutsiffran är samma
                    if (input[i] == input[j])
                    {
                        // Skapa delsträngen
                        string substring = input.Substring(i, j - i + 1);

                        // Kontrollera om start/slutsiffran inte förekommer mitt i strängen
                        string middle = substring[1..^1];
                        if (!middle.Contains(input[i]))
                        {
                            // Addera det matchande talet till totalSum som decimal
                            totalSum += decimal.Parse(substring);

                            // Skriv ut hela strängen med färgade siffror
                            for (int k = 0; k < input.Length; k++)
                            {
                                if (k >= i && k <= j)
                                {
                                    // Sätt färgen till röd för delsträngen
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(input[k]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    // Skriv ut resten av texten utan färg
                                    Console.Write(input[k]);
                                }
                            }
                            Console.WriteLine();  // Ny rad efter varje markerad sträng
                        }
                    }
                }
            }
        }

        // Skriv ut den totala summan av alla rödfärgade tal
        Console.WriteLine($"\nSumman av alla rödfärgade tal: {totalSum}");
    }
}
