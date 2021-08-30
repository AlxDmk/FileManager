using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileManager.Functions
{
    public static class Copy
    {
        static string File;
        static string NewDirectory;

        public static void Accept(string data)
        {
            Align aling = new Align(data);
            File = Align.Data;

            if (new DirectoryInfo(File).Exists || new FileInfo(File).Exists)
            {
                CheckDestDir(File);
            }

            else
            {
                Console.WriteLine("Введена неправильная информация!");
                Console.ReadKey();
                Program.Start();
            }
        }

        private static void CheckDestDir(string file)
        {
            Console.Write("Куда: ");
            string newDir = Console.ReadLine();
            Align newAlign = new Align(newDir);
            NewDirectory = Align.Data;

            if (!new DirectoryInfo(NewDirectory).Exists)
            {
                try
                {
                    new DirectoryInfo(NewDirectory).Create();
                }
                catch
                {
                    Console.WriteLine("Копирование не возможно");
                    Console.ReadKey();
                    Program.Start();
                }
            }

            if (new DirectoryInfo(File).Exists)
            {
                DirectoryCopy(File, NewDirectory);

            }
            else
            {
                FileInfo fl = new(File);
                string tempDir = Path.Combine(NewDirectory, fl.Name);
                fl.CopyTo(tempDir, true);
            }

        }
        private static void DirectoryCopy(string DirName, string destName)
        {

            DirectoryInfo dir = new DirectoryInfo(DirName);

            DirectoryInfo[] dirs = dir.GetDirectories();

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempDir = Path.Combine(destName, file.Name);
                file.CopyTo(tempDir, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string tempDir = Path.Combine(destName, subdir.Name);
                DirectoryCopy(subdir.FullName, tempDir);
            }

        }
    }
}
