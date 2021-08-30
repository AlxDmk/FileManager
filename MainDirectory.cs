using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileManager
{
    class MainDirectory
    {
        /*  Класс отвечает за:
         *  1. Вызов последней сохраненной директории (при открытии)
         *  2. Установки текущей директории в качестве послденей - передача информации для записи в root.txt
         *  3. Формирование StringBuilder текущей директории с вложенностью и передачи его в качестве строки в класс Paginate для вывода на консоль   
         */

        public static StringBuilder DirectoriesArray = new();
        public static DirectoryInfo mainRoot;
        public static string ROOT;
        

       public static void  SetDirectory(string root)
        {
            ROOT = root;
            DirectoriesArray.Clear();
            mainRoot = new(root);
            Pagination.ROOT = root;
            LastRoot.SaveRoot(root);
            int i = 0;
            DirectoriesArray.Append(root + ',');
            RecordRootToString(mainRoot, i);            

        }

        private static void RecordRootToString(DirectoryInfo root, int i)
        {
            string row = ">";
            i++;
            if (i ==3)                                                              // Указывается уровено вложенности
            {
                return;
            }

            try
            {
                foreach (DirectoryInfo dir in root.GetDirectories())
                {
                    DirectoriesArray.Append(row.PadLeft(i, '-') + dir.Name + ',');
                    RecordRootToString(dir, i);
                }
            }
            catch { }
            try
            {
                foreach (FileInfo fl in root.GetFiles())
                {
                    DirectoriesArray.Append(row.PadLeft(i, '-') + fl.Name + ',');
                }
            }
            catch { }
            
        }      


    }
}
