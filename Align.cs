using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
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
