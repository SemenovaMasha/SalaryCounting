using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting
{
    public class ExceptionsLogger
    {
        private static string path = "logger-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

        public static void logMessage(String message)
        {
            checkFile();

            File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + " Message: " + message + "\r\n");
          
        }
        static void checkFile()
        {
            if (!File.Exists(path))
                File.Create(path).Close();
            
            FileInfo f = new FileInfo(path);
            long lenght = f.Length;

            if (lenght > 2048 * 1024)//2Mb
            {
                path = "logger-" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + ".txt";
                File.Create(path).Close();
            }            

        }
    }
}
