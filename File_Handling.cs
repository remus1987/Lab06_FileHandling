using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.IO.File;

namespace FilesHandling
{
    class File_Handling
    {
        //public static void ReadFileStatic(int number)
        //{
        //    Console.WriteLine(number);
        //}
        #region Read_File
        public void ReadFile(string fileName)
        {
            //Don't use the File class name before Exists method as File is static class
            if (Exists(fileName))
            {
                //made possible by using static import
                string data = ReadAllText(fileName);
                // Below is same as above but without the using static import
                // string data2 = File.ReadAllText("File.txt"); //If not use the directive System.IO.File
            }
            else
            {
                StreamWriter sw = CreateText(fileName);
                sw.WriteLine("Yuppy with some text");
                sw.Close();
                string getBackData = ReadAllText(fileName);
                Console.WriteLine("Data returned from file {0}", getBackData);
            }
        }
        #endregion

        #region Read_Binary_Data
        public void ReadBinaryData(string fileName)
        {
            if (Exists(fileName))
            {
                byte[] binaryData = ReadAllBytes(fileName);
            }
            else
            {
                Create("File4.bin");
            }
        }
        #endregion

        #region Write_To_File
        public void WriteToFile(string fileName)
        {
            WriteAllText(fileName, "Write some text into filename");
        }
        #endregion

        #region WriteToFile_From_Array
        public void WriteToFileFromArray(string fileName)
        {
            string[] arrayToFile = { "1", "2", "3", "Anything goes" };
            WriteAllLines(fileName, arrayToFile);
        }
        #endregion

        #region Read_File_Line_To_Array
        public void ReadFileLineToArray(string fileName)
        {
            string[] arrayData = ReadAllLines(fileName);
        }
        #endregion

        #region Delete_File
        public void DeleteFile(string fileName)
        {
            if (Exists(fileName))
            {
                Delete(fileName);
            }
        }
        #endregion

        #region Copy_File
        public void CopyFile(string fileName1, string fileName2)
        {
            Copy(fileName1, fileName2, true);
        }
        #endregion

        #region Getting_File_Properties
        public void FileProperties(string fileName)
        {
            Console.WriteLine(GetCreationTime(fileName));
            Console.WriteLine(GetAttributes(fileName));
            Console.WriteLine(GetLastAccessTime(fileName));
            //Not all info can be found within the File class
            //The FileInfo class complements the File class
            FileInfo fileInfo = new FileInfo(fileName);
            string extension = fileInfo.Extension;
            FileAttributes otherProperties = fileInfo.Attributes;
        }
        #endregion
    }
}
