using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    /*  Вспомогательный класс. Преобразовывает короткий путь директории или файла в путь от корня. 
     *  Помогает использовать в командах только наименования папок или файлов в случае, когда они являются дочерними текущей директории
     */
    public  class Align
    {
        public static string Data;

        public  Align(string data)
        {

            SetAlign(data);
        }

        private static void SetAlign(string data)
        {
            if (data.Trim().StartsWith("c:\""))
            {
                Data = data;
            }
            else
            {
                Data = Path.Combine(Program.LAST_DIR, data) ;
            }

        }
    }
}
