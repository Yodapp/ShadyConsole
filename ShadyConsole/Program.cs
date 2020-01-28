using System;
using System.Collections.Generic;
using System.IO;

namespace ShadyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Let the user input a path to a folder, i.e. c:\my-folder\files (if the user prints 'exit' or 'quit', end the program)

            Console.Write("Path: ");
            string path = Console.ReadLine(); // Fråga användaren efter en path och spara den i en sträng (string är en datatyp som innehåller "text")

            /* 2. Complete the class called UserFolder so it contains: 
                    - a string with the path the user entered
                    - a bool if the folder exists or not
                    - and finally a List<string> with all filenames in the folder (if the folder doesn't exist) the List should be empty but initialized
                    - the class should be able to return the number of files as well.
            */

            // Steg 1: ----> Scrolla ner och titta på class UserFolder, en klass är ett objekt för att gruppera variabler och logik (metoder).

            // --------- FORTSÄTTNING ------------
            // Steg 2 efter att steg 1 är klart.
            UserFolder myFolder = new UserFolder(path);

            // Nu kan vi testa om vår instans fungerar,
            Console.WriteLine(myFolder.Path); // <--- Skriver ut sökvägen
            Console.WriteLine(myFolder.Exists); // <--- Skriver True om sökvägen finns annars skriver den False


            // 4. If no files was found, print a message to the console letting the user know that. Then skip the rest of the steps and start at 1.

            // 5. Otherwise, print total number of files in a message similar to this "The folder: .... contains XX files."

            // 6. Use any type of loop to print the three largest files in the list of Filenames (if the list contains less than three files, print the one or two files that do exist)

            // 7. Let the user start again at 1.

        }

        class UserFolder
        {
            // The only constructor for this class
            public UserFolder(string path) // <--- Tar emot ett argument som ska vara av typen string
            {
                // Det här är en konstruktor som tar emot en parameter, "path", tanken är att skapa en instans av det här objektet.
                // För att skapa en instans av en klass används konstruktorn för att konstruera objektet, exempelvis:
                // var folder = new UserFolder("c:\test");
                // Vi har nu en instans av UserFolder som heter "folder". Vill vi skapa ett till objekt gör vi så här,
                // var folder2 = new UserFolder("c:\test2");
                // Nu finns det två instanser av den här klassen.

                // I uppgiften stod det att vi skulle se till att klassen håller koll på den path som användaren matat in. Förslag,
                Path = path; // Path (med stort P) ser du 3 rader ner och path (med litet p) är det vi får in som argument till konstruktorn. Se högre upp.

                // Nästa steg var att låta klassen hålla koll på om sökvägen (path) finns, vi antar att det är en mapp.
                var exists = Directory.Exists(Path);
                Exists = exists; // <--- Spara true eller false i Exists
                // För att spara kod att skriva hade vi kunnat skriva
                Exists = Directory.Exists(path); // <--- Här använder jag path med litet p, det innehåller samma värde som Path eftersom vi sparade path till Path på rad 50.

                // Scrolla upp och fortsätt läs.
            }

            public string Path { get; private set; }
            public bool Exists { get; private set; }
            public List<string> Filenames { get; private set; }
            // Count should return the number of files in the folder or zero if the folder doesn't exist or is empty
            // As you see, Count doesn't have any "set", so it's "read only". Can you figure out a way to return the number of files anyway?
            public int Count { get; }
        }
    }
}
