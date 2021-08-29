using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class Pagination
    {
        static int CountRecordsPerPage = 30;
        static string Array;
        static int ArrayLength;
        static int CurrentPage;
        static int pages;

        public static void PrintPaginatedRoot(string array)
        {
            Array = array;
            Console.Clear();
            CurrentPage = 1;
            ArrayLength = (array.Split(',').Length);
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

                    Console.WriteLine(Array.Split(',')[i]);
                    
                    end = i;                   
                    
                }
                Console.WriteLine();
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

                Console.WriteLine("Для постраничной навигации используйте комманду page + № ");
                
                //Console.ReadKey();
            }
        }
        public static void MovePage(string num)
        {
            CurrentPage = Convert.ToInt32(num);

            //if (Console.ReadKey().Key == ConsoleKey.LeftArrow && CurrentPage != 1)
            //{
            //    CurrentPage--;               

            //}
            //if (Console.ReadKey().Key == ConsoleKey.RightArrow && CurrentPage != pages)
            //{
            //    CurrentPage++;
                
            //}
            RealPrintPaginatedRoot();

        }
        
    }
}
