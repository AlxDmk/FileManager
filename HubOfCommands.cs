using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class HubOfCommands
    {

        static string CommandMethod;
        static string CommandBody;
        public static void SeperateCommandLine(string command)

        {
            CommandMethod = command.Split(" ").First();
            
            CommandBody= command.Split(" ").ElementAt(1);
            Console.WriteLine(CommandMethod);
            Console.WriteLine(CommandBody);

            SwitchTheCommand();
        }

        private static void SwitchTheCommand(){

            switch (CommandMethod)
            {
                case "exit":
                    break;
                case "change" :
                    Functions.ChangeDirectory.ChangeDirectoryMethod(CommandBody);
                    break;

                default:
                    break;
            }

        }

        


    }
}
