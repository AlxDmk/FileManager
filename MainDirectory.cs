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
        static string Root;
        static DirectoryInfo mainRoot ;
        static DirectoryInfo[]  RootArray ;
        static FileInfo[] RootFilesArra;

        public MainDirectory(string root)
        {
            Root = root;
            mainRoot = new DirectoryInfo(Root);
            RootArray = mainRoot.GetDirectories();
            

        }

        
        

       public static void  SetDirectory(string root)
        {
           
            try
            {
                
                Root = root;
                mainRoot = new DirectoryInfo(Root);
               
                RootArray = mainRoot.GetDirectories();
                LastRoot.SaveRoot(root);

                RootFilesArra = mainRoot.GetFiles();
                PrintRoot();
                               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Такой директории не существует");
                Console.ReadKey();
            }
            
            

        }

        public static  void PrintRoot()
        {
            Console.Clear();
            Console.WriteLine(mainRoot.FullName);
           
            foreach(DirectoryInfo r in RootArray)
            {
                Console.WriteLine("-->  "+r.Name);

            }
            foreach(FileInfo f in RootFilesArra)
            {
                Console.WriteLine("-->  "+f.Name);
            }


            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine(mainRoot.Name);
            Console.WriteLine(mainRoot.FullName);
            
        }


    }
}
