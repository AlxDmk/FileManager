using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Functions
{
        class ChangeDirectory
    {
        
        public static void ChangeDirectoryMethod(string newDirectory)
        {
            //Console.Write("Введите новую директорию_");
            //string newDirectory = Console.ReadLine();

            MainDirectory.SetDirectory(newDirectory);


        }
        
    }
}
