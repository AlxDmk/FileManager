using System;


namespace FileManager
{
    class Program

    {        
        public static string LAST_DIR ;
        static string  Command;
        public static int  FooterArea;
        public static int InfoArea = (int)Math.Truncate(Console.WindowHeight * 0.67);

        static void Main(string[] args)
        {           
            Start();             
        }

        static public void Start()
        {
                       
            MainDirectory.SetDirectory(LastRoot.LoadRoot());                                // Идет запрос на последнее состояние
            LAST_DIR = LastRoot.LoadRoot();
            Pagination.PrintPaginatedRoot(MainDirectory.DirectoriesArray.ToString());       // в MainDirectory  в StringBuilder собирается string из всех подкаталогов и фалов текущей директории (до третьего уровня) и в качестве строки   
                                                                                            // передается  в Pagination. Там он преобразуется в массив и формируется пагинация текущей директории с подкаталогами  
        }                                                                                   
        public static void Continue()
        {
            
            do
            {              
                
                FooterArea = (int)Math.Truncate(Console.WindowHeight * 0.95);               // Командная строк
                Console.SetCursorPosition (0, FooterArea);
                for (int i = 1; i < Console.WindowWidth; i++)
                {
                    Console.Write('_');
                }
                Console.WriteLine();
                Console.WriteLine();
                LAST_DIR = (LastRoot.LoadRoot());
                Console.Write(LAST_DIR + '>');
                Command = Console.ReadLine();
                HubOfCommands.SeperateCommandLine(Command);
               
            }

            while (Command != "exit");

        }

    }
}
