using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager.Functions
{
        class ChangeDirectory
    {
        static string Root;
        public static void ChangeDirectoryMethod(string newDirectory)
        {

            Align aling = new Align(newDirectory);
            Root = Align.Data;

                       
            if(new DirectoryInfo(Root).Exists)
            {
                MainDirectory.SetDirectory(Root);
                Pagination.PrintPaginatedRoot(MainDirectory.DirectoriesArray.ToString());
            }
            else { 
                
                Console.WriteLine($"Директории {Root} не существует");
                Console.ReadKey();
                Program.Start();
            }           

        }       
                
    }
}
