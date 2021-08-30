using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager.Functions
{
     class FileInformation
    {
        static string FileRoot;
        static FileInfo FILE; 
        public static void  InfoForFileSet(string file)
        {

            if (file.Trim().StartsWith("c:\""))
            {
                FileRoot = file;
            }
            else
            {
                FileRoot = Program.LAST_DIR + @"\" + file;
            }

           FILE =  new (FileRoot);
            if(FILE.Exists)
            { 
                MiddleArea.PrintInfo(FileRoot, false);
            }

            else
            {
                Console.WriteLine($"Файла {FILE.FullName} не существует!");
                
            }
            
            
        }

        public static void PrintFileInfo()
        {
            for (int i = Program.InfoArea; i < Program.FooterArea; i++)
            {
                Console.WriteLine(new String(' ', Console.WindowWidth));

            }
            Console.SetCursorPosition(0, Program.InfoArea);

            for (int i = 1; i < Console.WindowWidth; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("----- File Information -----");
            Console.WriteLine($"\nПолное имя: {FILE.FullName}");
            Console.WriteLine($"\nИмя: {FILE.Name}");
            Console.WriteLine($"\nРодительская директория: {FILE.DirectoryName}");
            Console.WriteLine($"\nСоздан: {FILE.CreationTime}");
            Console.WriteLine($"\nАттрибут: {FILE.Attributes}");
            Console.WriteLine($"\nРазмер: {FILE.Length / 1000} KБайт");
            Console.ReadKey();
        }
    }
}
