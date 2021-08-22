using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileManager
{
   public static class LastRoot
    {
        static string lastRoot = "lastRoot.txt";
        public static string LastDir;

        public static string LoadRoot ()
        {
            LastDir = File.ReadAllText(lastRoot);
            return LastDir;
        }

        public static void  SaveRoot(string root)
        {
           File.WriteAllText(lastRoot, root);
        }
    }
}
