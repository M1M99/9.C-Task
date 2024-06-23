using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    public class Menu
    {
        public static void  showMenu()
        {
        User sser = new User();
            while (true)
            {
                Control control = new Control();
                Console.Write("Gundelik Norman : ");
                control.d();
                Console.Write("1.Su ich\n");
                Console.Write("2.Tarixche\n");
                Console.Write("3.Gunu Bitir\n");
                Console.Write("4.Chixish\n");
                Console.Write("Choise : ");
                var ff = (Console.ReadKey());
                if (ff.Key == ConsoleKey.D1)
                {
                    control.drinkWater();
                }
                else if (ff.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    control.History();
                    Console.WriteLine("Davam Etmek Ucun Enteri Klik Et ! ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (ff.Key == ConsoleKey.D3)
                {
                    control.FinishDay();
                    Console.Clear();
                    Console.WriteLine("Gun Bitti !");
                    Thread.Sleep(2200);
                    Console.Clear();
                }
                else if (ff.Key == ConsoleKey.D4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Exit Is Successful");
                    break;
                }
                else { 
                    Console.Clear();
                    showMenu();
                }
                control.SaveChanges();
            }

        }
    }
}
