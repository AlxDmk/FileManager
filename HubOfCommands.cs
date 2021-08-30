using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class HubOfCommands
    {
        /* Класс получает команду с командной строки, пытается преобразовать в массив (выделить первое слово в строке - CommandMethod и остаток массива - CommandBody).
         * В зависимости от значения CommandMethod запускает определенные методы соответствующих классов.         
         */

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
                case "cd" :
                    Functions.ChangeDirectory.ChangeDirectoryMethod(CommandBody);
                    break;
                case "nav":
                    Program.Start();
                    break;
                case "file":
                    Functions.FileInformation.InfoForFileSet(CommandBody);
                    Program.Start();
                    break;
                case "del":
                    if (CommandBody!=null)
                    {
                        Functions.Delete.DeleteSubDir(CommandBody);
                    }
                    else
                    {
                        Functions.Delete.DeleteSelf();
                    }
                    Program.Start();
                    break;
                case "copy":
                    Functions.Copy.Accept(CommandBody);
                    Program.Start();
                    break;

                default:
                    break;
            }

        }

        


    }
}
