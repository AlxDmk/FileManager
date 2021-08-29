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
            string[] sep = command.Split(null, 2);
            CommandMethod = sep[0];

            if (sep.Length>1)
            {
                CommandBody = sep[1];
            }

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
                case "page":
                    Pagination.MovePage(CommandBody);
                    break;
                default:
                    break;
            }

        }

        


    }
}
