using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class MiddleArea
    {
        /*
            Класс отвечает за вывод Информационного раздела. В зависимости от того какой запрос пришел : директория или файл - определяет чью Информацию выводить
        */
        public static void PrintInfo(string data, bool choice)
        {
            Console.SetCursorPosition(0, Program.InfoArea);

            for (int i = 1; i < Console.WindowWidth; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();
                        
            if (choice)
            {
                InfoForCategory info = new(data);
                info.PrintCategoryInfo();
            }
            else if (!choice)
            {
                Functions.FileInformation.PrintFileInfo();
            }
            else
            {
                Console.WriteLine("Введены неверные данные");
            }

            

        }


    }
}
