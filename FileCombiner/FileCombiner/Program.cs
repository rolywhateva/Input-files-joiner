using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileCombiner
{
    class Program
    {
        static void Main(string[] args)
        {

           string[] files =  Directory.GetFiles(Directory.GetCurrentDirectory(), "*.in");
            Console.WriteLine(files.Length);
            Console.WriteLine(Directory.GetCurrentDirectory());
            StreamWriter writer = new StreamWriter("date.out");
            foreach(string file in files)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                   // Console.WriteLine("*");
                    string[] words = file.Split(new char[] { '\\', ':', 'C', 'D' }, StringSplitOptions.RemoveEmptyEntries);
                    writer.WriteLine(words[words.Length-1]);

                    writer.WriteLine(reader.ReadLine());
                }
            }
            writer.Close();
            Console.ReadKey();
            
        }
    }
}
