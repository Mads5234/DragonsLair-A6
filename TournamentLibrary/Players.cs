using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TournamentLibrary
{
    public class Players
    {
        
        public static void TeamName()
        {
            String path = (@"..\..\TeamListNew.txt");
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    String AH = Console.ReadLine();
                    writer.Write(AH);
                    writer.Close();
                }
            }
            else
            {
                using (StreamWriter writer2 = new StreamWriter(path, true))
                {
                    String AH = Console.ReadLine();
                    writer2.WriteLine();
                    writer2.Write(AH);
                    writer2.Close();
                }
            }
        }
        public static void TeamReader()
        {
            String path = (@"..\..\TeamListNew.txt");
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
                reader.Close();
            }
        }
        public static void TeamModifier()
        {
            Console.WriteLine("Hvad vil du ændre?");
            string textA = Console.ReadLine();
            Console.WriteLine("hvad skal det ændres til?");
            string textB = Console.ReadLine();

            String path = (@"..\..\TeamListNew.txt");
            StreamReader reader = new StreamReader(File.OpenRead(path));
            string fileContent = reader.ReadToEnd();
            reader.Close();

            fileContent = fileContent.Replace(textA, textB);
            StreamWriter writer = new StreamWriter(File.OpenWrite(path));
            writer.Write(fileContent);
            writer.Close();
        }
    }
}
