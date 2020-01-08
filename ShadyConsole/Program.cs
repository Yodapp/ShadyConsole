using System;
using System.Collections.Generic;

namespace ShadyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Let the user input a path to a folder, i.e. c:\my-folder\files (if the user prints 'exit' or 'quit', end the program)

            /* 2. Complete the class called UserFolder so it contains: 
                    - a string with the path the user entered
                    - a bool if the folder exists or not
                    - and finally a List<string> with all filenames in the folder (if the folder doesn't exist) the List should be empty but initialized
                    - the class should be able to return the number of files as well.
            */

            // 3. The instance of the class UserFolder should be stored in a local variable

            // 4. If no files was found, print a message to the console letting the user know that. Then skip the rest of the steps and start at 1.

            // 5. Otherwise, print total number of files in a message similar to this "The folder: .... contains XX files."

            // 6. Use any type of loop to print the three largest files in the list of Filenames (if the list contains less than three files, print the one or two files that do exist)

            // 7. Let the user start again at 1.

        }

        class UserFolder
        {
            // The only constructor for this class
            public UserFolder(string path)
            {
                // 
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
