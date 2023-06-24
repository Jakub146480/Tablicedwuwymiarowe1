using System;

class tablicadw1
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];
        int counter = 1;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                // Wiersze parzyste - wypełnianie rosnąco
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = counter;
                    counter++;
                }
            }
            else
            {
                // Wiersze nieparzyste - wypełnianie malejąco
                for (int j = 9; j >= 0; j--)
                {
                    tablica[i, j] = counter;
                    counter++;
                }
            }
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}