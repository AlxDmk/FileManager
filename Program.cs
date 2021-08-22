using System;
using System.IO;
using System.Text.Json;

namespace FileManager
{
    class Program
    {

        static string  Command;
       
        static void Main(string[] args)
        {

            Start();

            do
            {
                Console.Write("Введите команду: ");
                Command = Console.ReadLine();
                HubOfCommands.SeperateCommandLine(Command);
            }

            while (Command != "exit");


            

            //ConsoleKeyInfo keypress;

            //do
            //{
            //    Console.Write("Введите команду_");
            //    keypress = Console.ReadKey();


            //    if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
            //    {
            //        if (keypress.Key == ConsoleKey.C)
            //        {
            //            Functions.ChangeDirectory.ChangeDirectoryMethod();
            //        }
            //    }

            //} while (keypress.Key!=ConsoleKey.Escape);



            //while (q != "n")
            //    {
            //        Console.Write("Введите директорию_");
            //        q = Console.ReadLine();
            //        MainDirectory.SetDirectory(q);
            //        MainDirectory.PrintRoot();
            //    }






        }

        static public void Start()
        {
            //MainDirectory startDir = new ();
            MainDirectory.SetDirectory(LastRoot.LoadRoot());
            
            

        }

    }
}
