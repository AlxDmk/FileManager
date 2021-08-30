using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    class InfoForCategory
    {
        public static long MEMORY_SIZE;
        public static int COUNT_OF_DIRS;
        public static int COUNT_OF_FILES;
        public static DirectoryInfo CURRENT_DIRECTORY;
        public static string ROOT;

       

        public  InfoForCategory(string root)

        {
            
            CURRENT_DIRECTORY = new(root);            
            MEMORY_SIZE = 0;

            FindMemorySizeOfRoot();
                      
        }

        private void FindMemorySizeOfRoot()
        {
            try
            {
                COUNT_OF_DIRS = CURRENT_DIRECTORY.GetDirectories().Length;
                COUNT_OF_FILES = CURRENT_DIRECTORY.GetFiles().Length;
                foreach (FileInfo fr in CURRENT_DIRECTORY.GetFiles())
                {
                    MEMORY_SIZE += fr.Length;
                }

                FindMemorySize(CURRENT_DIRECTORY);
            }
            catch { }
            
        }

        private void FindMemorySize(DirectoryInfo root)
        {
            foreach (DirectoryInfo dir in root.GetDirectories())
            {

                try
                {
                    COUNT_OF_DIRS += dir.GetDirectories().Length;
                    FileInfo[] files = dir.GetFiles();
                    COUNT_OF_FILES += files.Length;

                    foreach (FileInfo fl in files)
                    {
                        MEMORY_SIZE += fl.Length;
                    }

                    FindMemorySize(dir);
                }
                catch
                {

                }
            }
        }

        public  void PrintCategoryInfo()
        {
            
            Console.WriteLine();
            Console.WriteLine("----- Directory Information -----");
            Console.WriteLine($"\nПолное имя: {MainDirectory.mainRoot.FullName}");
            Console.WriteLine($"\nИмя: {MainDirectory.mainRoot.Name}");
            Console.WriteLine($"\nРодитель: {MainDirectory.mainRoot.Parent}");
            Console.WriteLine($"\nСоздан: {MainDirectory.mainRoot.CreationTime}");
            Console.WriteLine($"\nСоздан: {MainDirectory.mainRoot.Attributes}");
            string info = new(Program.LAST_DIR);
            Console.WriteLine($"\nКоличество подкаталогов: {COUNT_OF_DIRS} ");
            Console.WriteLine($"\nКоличество файлов: {COUNT_OF_FILES} ");
            Console.WriteLine($"\nПримерный размер: {MEMORY_SIZE / 1000} KБайт");
        }
    }
}
