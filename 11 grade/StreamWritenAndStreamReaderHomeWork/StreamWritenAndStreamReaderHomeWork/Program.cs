using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWritenAndStreamReaderHomeWork
{
    class Program
    {
        static string path = @"./";
        static void CreateEmptyFile(string name)
        {
            path += name;
            path += ".txt";
            using (FileStream fs = File.Create(path)) 
            {

            }
            path = @"./";
        }
        static void showDirectory(string path)
        {
            path = @"./";
            var txtFiles = Directory.EnumerateFiles(path, "*.txt");
            foreach (string curentFile in txtFiles)
            {
                Console.WriteLine(curentFile);
            }
        }

        static void searchingAName(string path,string searching)
        {
            path = "./" + path + ".txt";
            using (StreamReader sr=new StreamReader(path)) 
            {
                string contents = sr.ReadToEnd();
                if (contents.Contains(searching))
                {
                    Console.WriteLine("{0} is found!",searching);
                }
                else
                {
                    Console.WriteLine("{0} not found! If you want you can write it!",searching);
                }
            }
            path = @"./";
        }

        static void WriteANameInFile(string path,string name)
        {
            using (StreamWriter sw=new StreamWriter(path,true))
            {
                sw.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            string option = "";
            Console.Write("Choose an option(Create/Write/Search/Exit): ");
            option = Console.ReadLine();
            while (true)
            {
                if (option.ToLower() == "exit")
                {
                    break;
                }
                if (option.ToLower() == "create")
                {
                    try
                    {
                        string name = "";
                        Console.Write("Enter name of file: ");
                        name = Console.ReadLine();
                        CreateEmptyFile(name);
                        Console.WriteLine("Done file was created");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                    }
                }
                else
                {
                    if (option.ToLower() == "write")
                    {
                        string operation = "";
                        Console.Write("Enter a file name in witch you will add name(if you want to see files in directory type 'show'): ");
                        operation = Console.ReadLine();
                        string fileNameInput = "";
                        if (operation.ToLower() == "show")
                        {
                            showDirectory(path);
                            Console.Write("Enter file name: ");
                            fileNameInput = Console.ReadLine();
                        }
                        else
                        {
                            fileNameInput = operation;
                        }
                        string input = "";
                        Console.Write("Enter a text you want to add: ");
                        input = Console.ReadLine();
                        string filePath = "./" + fileNameInput + ".txt";
                        WriteANameInFile(filePath, input);
                        Console.Write("Done! You add: {0}", input);
                        Console.WriteLine();
                    }
                    else 
                    {
                        if (option.ToLower() == "search") 
                        {
                            string operation = "";
                            Console.Write("Enter a file name in witch you will search (if you want to see files in directory type 'show'): ");
                            operation = Console.ReadLine();
                            string fileNameInput = "";
                            if (operation.ToLower() == "show")
                            {
                                showDirectory(path);
                                Console.Write("Enter file name: ");
                                fileNameInput = Console.ReadLine();
                            }
                            else
                            {
                                fileNameInput = operation;
                            }
                            string input = "";
                            Console.Write("Enter a name which you search: ");
                            input = Console.ReadLine();
                            searchingAName(fileNameInput, input);
                        }
                    }
                }
                option = "";
                Console.Write("Choose an option(Create/Write/Search/Exit): ");
                option = Console.ReadLine();
            }
        }
    }
}
