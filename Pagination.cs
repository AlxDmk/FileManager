using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class Pagination
    {
        static int CountRecordsPerPage = (int)Math.Truncate(Console.WindowHeight*0.66-4);
        static string ArrayString;
        static string[] Array;
       
        static int ArrayLength;
        static int CurrentPage;
        static int pages;
        public static string ROOT = MainDirectory.ROOT; 

        public static void PrintPaginatedRoot(string array)
        {

            ArrayString = array;
            Array = ArrayString.Split(',');
            Console.Clear();
            CurrentPage = 1;
            ArrayLength = (Array.Length);
            pages = ArrayLength / CountRecordsPerPage;
            if (ArrayLength % CountRecordsPerPage >0)
            {
                pages++;
            }
            RealPrintPaginatedRoot();
            
        }

        private static void RealPrintPaginatedRoot()
        {
            int i, j;
            Console.Clear();
            Console.ResetColor();
            for (int k = CurrentPage; k < CurrentPage + 1; k++)
            {
                i = (k - 1) * CountRecordsPerPage;
                int start = i;
                int end = 0;
                j = k * CountRecordsPerPage;

                for (; i < j; i++)
                {
                    if ( i>= ArrayLength)
                    {
                        break;
                    }

                    Console.WriteLine(Array[i]);
                    
                    end = i;                   
                    
                }
                Console.WriteLine();
                if (pages>1)
                {
                    for (int t = 1; t <= pages; t++)
                    {

                        if (t == k)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"[{t}] ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($"[{t}] ");
                        }

                    }

                    Console.WriteLine();
                    Console.WriteLine("Для навигации используйте клавиши" + "←" + "→");
                }
                
                Console.WriteLine("Для выхода в командную строку нажмите любую клавишу");


                MiddleArea.PrintInfo(ROOT, true);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow :
                        if (CurrentPage > 1)
                        {
                            CurrentPage--;
                        }
                        else
                        {
                            CurrentPage = 1;
                        }

                        ClearArea();
                        RealPrintPaginatedRoot();
                        break;
                    case (ConsoleKey.RightArrow ):
                        if (CurrentPage < pages)
                        {
                            CurrentPage++;
                        }
                        else
                        {
                            CurrentPage = pages;
                        }

                        ClearArea();
                        RealPrintPaginatedRoot();
                        break;

                    default:
                        Program.Continue();
                        break;
                }                
            }
        }

        private static void ClearArea()
        {
            for (int i = 0; i < CountRecordsPerPage; i++)
            {
                Console.WriteLine(new String(' ', Console.WindowWidth));
            }
        }
    }
}
