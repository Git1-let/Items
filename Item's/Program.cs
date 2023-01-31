using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Item_s
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "labda", "autó", "alma", "gumikacsa", "medence", "kalapács" };
            Random itemsGenerate = new Random();
            int labda = 0;
            int auto = 0;
            int alma = 0;
            int gumikacsa = 0;
            int medence = 0;
            int kalapacs = 0;
            List<int> item = new List<int>();
            StreamWriter write = new StreamWriter("item.txt", true, Encoding.UTF8);
            for (int i = 0; i < 5; i++)
            {
                string rndItem = Convert.ToString(itemsGenerate.Next(0 ,501));
                if (rndItem == "labda")
                {
                    labda++;
                }
                if (rndItem == "autó")
                {
                    auto++;
                }
                if (rndItem == "alma")
                {
                    alma++;
                }
                if (rndItem == "gumikacsa")
                {
                    gumikacsa++;
                }
                if (rndItem == "medence")
                {
                    medence++;
                }
                if (rndItem == "kalapacs")
                {
                    kalapacs++;
                }
            }
            write.Flush();
            write.Close();

            Console.WriteLine($"Ennyi labda van > {labda}");
            Console.WriteLine($"Ennyi autó van > {auto}");
            Console.WriteLine($"Ennyi alma van > {alma}");
            Console.WriteLine($"Ennyi gumikacsa van > {gumikacsa}");
            Console.WriteLine($"Ennyi medence van > {medence}");
            Console.WriteLine($"Ennyi kalapács van > {kalapacs}");

            Console.ReadKey();
        }
    }
}
