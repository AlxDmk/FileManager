using System;
using System.IO;


namespace FileManager
{
    class Program
    {

        static string  Command;
       
        static void Main(string[] args)
        {

            Start();
            Continue();

            
        }

        static public void Start()
        {
            
            MainDirectory.SetDirectory(LastRoot.LoadRoot());
            Pagination.PrintPaginatedRoot(MainDirectory.DirectoriesArray.ToString());
            
            

        }
        static void Continue()
        {
            string lastDir = (LastRoot.LoadRoot());
            do
            {
                Console.Write(lastDir + '>');
                Command = Console.ReadLine();
                HubOfCommands.SeperateCommandLine(Command);
            }

            while (Command != "exit");

        }

    }
}
