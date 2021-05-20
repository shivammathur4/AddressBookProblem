using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    class ReadWrite
    {
        /// <summary>
        /// Reads from stream reader.
        /// </summary>
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\SHIVAM MATHUR\source\repos\AddressBookProblem\AddressBookProblem\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String fileData = "";
                    while ((fileData = sr.ReadLine()) != null)
                        Console.WriteLine((fileData));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }

        /// <summary>
        /// Writes the using stream writer.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void WriteUsingStreamWriter(List<string> data)
        {
            string path = @"C:\Users\SHIVAM MATHUR\source\repos\AddressBookProblem\AddressBookProblem\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (string contact in data)
                    {
                        streamWriter.WriteLine(contact);
                    }
                    streamWriter.Close();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
    }
}
