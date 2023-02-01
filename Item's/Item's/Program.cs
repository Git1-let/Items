using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Item_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "autó", "gumikacsa", "alma", "táska", "virág" };
            Random itemGenerate = new Random();
            int auto = 0;
            int gumikacsa = 0;
            int alma = 0;
            int taska = 0;
            int virag = 0;

            List<int> Item = new List<int>();
            StreamWriter write = new StreamWriter("Item.txt", true, Encoding.UTF8);
            for (int i = 0; i < 500; i++)
            { 
                string rndItem = Convert.ToString(itemGenerate.Next(0, 5));
                foreach (var item in Item)
                {
                    Item.Add(item);
                    if (rndItem == "autó")
                    {
                        auto++;
                    }
                    else if (rndItem == "gumikacsa")
                    {
                        gumikacsa++;
                    }
                    else if (rndItem == "alma")
                    {
                        alma++;
                    }
                    else if (rndItem == "táska")
                    {
                        taska++;
                    }
                    else if (rndItem == "virág")
                    {
                        virag++;
                    }
                }
                Console.Write(rndItem);
                write.Flush();
                write.Close();

                Console.WriteLine($"Ennyi autó van > {auto}");
                write.WriteLine($"Ennyi autó van > {auto}");
                Console.WriteLine($"Ennyi gumikacsa van > {gumikacsa}");
                write.WriteLine($"Ennyi gumikacsa van > {gumikacsa}");
                Console.WriteLine($"Ennyi alma van > {alma}");
                write.WriteLine($"Ennyi alma van > {alma}");
                Console.WriteLine($"Ennyi táska van > {taska}");
                write.WriteLine($"Ennyi táska van > {taska}");
                Console.WriteLine($"Ennyi virág van > {virag}");
                write.WriteLine($"Ennyi virág van > {virag}");

                Console.ReadKey();

                StreamReader read = new StreamReader("Item.txt", Encoding.UTF8);
                while (!read.EndOfStream)
                {
                    string input = read.ReadLine();
                }
                foreach (var item in Item)
                {
                    if (rndItem == "autó")
                    {
                        auto++;
                    }
                    else if (rndItem == "gumikacsa")
                    {
                        gumikacsa++;
                    }
                    else if (rndItem == "alma")
                    {
                        alma++;
                    }
                    else if (rndItem == "táska")
                    {
                        taska++;
                    }
                    else if (rndItem == "virág")
                    {
                        virag++;
                    }
                }

                StreamWriter wrt = new StreamWriter("result.txt", true, Encoding.UTF8);
                wrt.WriteLine($"Ennyi autó van > {auto}");
                wrt.WriteLine($"Ennyi gumikacsa van > {gumikacsa}");
                wrt.WriteLine($"Ennyi alma van > {alma}");
                wrt.WriteLine($"Ennyi táska van > {taska}");
                wrt.WriteLine($"Ennyi virág van > {virag}");
                wrt.Flush();
                wrt.Close();

            }
        }
    }
}
