using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project
{
    internal class File_Handling
    {
        public string Path = @"D:\ACCP\C#\pakistan.txt";

        public void creteFile()
        {
            FileStream fs = null;
            try
            {
                if (File.Exists(Path))
                {
                    Console.WriteLine("File is already Exist");
                }
                else
                {
                    fs = File.Create(Path);
                    Console.WriteLine("File is created Successfully!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Error: " + ex.Message);
            }
            finally
            {
             
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public void FileExist()
        {
            try
            {
                if (File.Exists(Path))
                {
                    Console.WriteLine("Yes there is file Exist");
                }
                else
                {
                    Console.WriteLine("File is not Exist...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Check Error: " + ex.Message);
            }
         
            finally
            {
                
            }
        }

        public void addContentInFile()
        {
            StreamWriter sw = null;
            try
            {
                if (File.Exists(Path))
                {
                    sw = new StreamWriter(Path, true);
                    sw.WriteLine("New Text is added");
                    Console.WriteLine("Data is successfully Saved!!!");
                }
                else
                {
                    Console.WriteLine("File is not Exist...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Write Error: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void ReadContentfromFile()
        {
            StreamReader sr = null;
            try
            {
                if (File.Exists(Path))
                {
                    sr = new StreamReader(Path);
                    string mydata = sr.ReadToEnd();
                    Console.WriteLine("--- File Data ---");
                    Console.WriteLine(mydata);
                }
                else
                {
                    Console.WriteLine("File is not Exist...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Error: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close(); 
                }
            }
        }

        public void deleteFile()
        {
            try
            {
                if (File.Exists(Path))
                {
                    File.Delete(Path);
                    Console.WriteLine("File is Successfully Deleted!!");
                }
                else
                {
                    Console.WriteLine("File is Not Exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Error: " + ex.Message);
            }
            finally
            {
               
            }
        }
    }
}