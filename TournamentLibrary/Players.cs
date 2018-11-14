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
    }
}
