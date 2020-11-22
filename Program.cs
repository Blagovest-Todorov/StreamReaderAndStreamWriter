using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StreamReadWriter
{
    class Program
    {
        static void Main()
        {
            try
            {

                var reader = new StreamReader(@"C:\Users\Bla\source\repos\TextFiles\ReadingFileWritingToFile\bin\Debug\netcoreapp3.1\FileReadingatxt");
                var writer = new StreamWriter(@"C:\Users\Bla\source\repos\TextFiles\ReadingFileWritingToFile\bin\Debug\netcoreapp3.1\FileWriting.txt");

                using (reader)
                {
                    string currentLine = reader.ReadLine();
                    int count = 1;
                    using (writer)
                    {

                        while (currentLine != null)
                        {
                            writer.WriteLine("{0:D2}. {1}", count, currentLine);
                            count++;
                            currentLine = reader.ReadLine();
                            // Console.WriteLine(currentLine);
                            // Console.WriteLine("{0:D2}. {1}", count, currentLine);
                        }//We can not at the same time read form file and write into the same file ..throws an exception//Principle of concurency
                         //many users may read from one file, gut at the same time writiung is not allowed/ 
                    }


                }

            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("the File is not found. Try gain :  FileReadinga.txt "); ;
            }
            //Streams are the main Iput/Output/ mechanism of .Net
            //The StreamReader Class and the ReadLine() method are used to read text files
            //the StreamWriter class and the WriteLine() methosd are used to write test files
            //Exceptions are unusual events or erros conditions
            //Exceptions can be handeled by try-catch finally blocks






        }
    }
}
