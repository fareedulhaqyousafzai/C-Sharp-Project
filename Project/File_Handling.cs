
using System;
using System.
Collections.Generic;
using System.Text;

namespace Project

{

    internal class File_Handling

    {

        public string Path = @"D:\ACCP\C#\data.txt ";



        public void show()

        {

            if (File.Exists(Path))

            {

                Console.WriteLine("Yes there is file...");

            }

            else

            {

                Console.WriteLine("File is not Found...");

            }





        }

    }

}