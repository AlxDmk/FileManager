using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager.Functions
{
     public static class Delete
    {
        static string File;
        
        public static void  DeleteSubDir (string file)
        {
            Align aling = new Align(file);
            File = Align.Data;

            if (new DirectoryInfo(File).Exists)
            {
                DirectoryInfo tempDir = new DirectoryInfo(File);
                Console.Write("Удалить директорию  Y / N ?");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:                        
                        tempDir.Delete(true);                        
                        break;
                    case ConsoleKey.N:
                        break;
                    default:
                        break;
                }
                
            }  
            
            else if(new FileInfo(File).Exists)
            {
                Console.Write($"Удалить файл {new FileInfo(File).FullName}  Y / N ?");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:                        
                        new FileInfo(File).Delete();
                        break;
                    case ConsoleKey.N:
                        break;
                    default:
                        break;
                }
            }
         }

        public static void DeleteSelf()
        {  

            Console.Write("Удалить директорию  Y / N ?");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Y:
                    DirectoryInfo temp = new DirectoryInfo(LastRoot.LastDir);
                    LastRoot.SaveRoot(temp.Parent.FullName);
                    temp.Delete(true);
                    break;
                case ConsoleKey.N:
                    break;
                default:
                    break;
            }            
        }
        
    }
}
