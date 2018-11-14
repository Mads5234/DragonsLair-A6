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
            using (StreamWriter writer = new StreamWriter("Teamlist.txt"))
            {
                String AH = Console.ReadLine();
                writer.Write(AH);
            }
        }
        public static void TeamReader()
        {
            
            using (StreamReader reader = new StreamReader("Teamlist.txt"))
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
