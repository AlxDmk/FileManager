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
        public static StringBuilder DirectoriesArray = new();
        
        

       public static void  SetDirectory(string root)
        {

            DirectoriesArray.Clear();
            DirectoryInfo mainRoot = new(root);
            LastRoot.SaveRoot(root);
            int i = 0;
            DirectoriesArray.Append(root + ',');
            RecordRootToString(mainRoot, i);

            

        }

        private static void RecordRootToString(DirectoryInfo root, int i)
        {
            string row = ">";
            i++;
            if (i ==3)
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
