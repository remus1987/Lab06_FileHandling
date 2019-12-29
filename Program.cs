using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using static System.IO.File;

namespace FilesHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new object of FileHandling
            File_Handling fh = new File_Handling();
            fh.ReadFile("File3.png");
            fh.FileProperties("File3.png");
        }
    }
}
