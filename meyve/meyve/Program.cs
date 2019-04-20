using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meyve
{
    class Program
    {
        static void Main(string[] args)
        {
           

            meyve banan = new meyve();
            banan.name = "banan";
            banan.price = 3;

            meyve kivi = new meyve();
            kivi.name = "kivi";
            kivi.price = 8;

            meyve portagal = new meyve();
            portagal.name = "portagal";
            portagal.price = 2;
         
         
            while (1 == 1)
            {
                Console.WriteLine("meyvelerden var:{0} / {1} / {2}", banan.name, kivi.name, portagal.name);
                string input = Console.ReadLine();
                Console.WriteLine("pulunuz ne qederdir?");
                string money = Console.ReadLine();
                int currentMoney = Convert.ToInt32(money);


                if (input == "banan" && banan.price < currentMoney)
                {

                    if (banan.price > currentMoney)
                    {
                        Console.WriteLine("ala bilmessen");

                    }
                    else
                    {
                        Console.WriteLine("ala bilersen");

                    }

                }
                else if (input == "kivi")
                {
                    if (kivi.price > currentMoney)
                    {
                        Console.WriteLine("ala bilmersen");

                    }
                    else
                    {
                        Console.WriteLine("ala bilersen");

                    }

                }

                else if (input == "portagal")
                {
                    if (portagal.price > currentMoney)
                    {
                        Console.WriteLine("ala bilmersen");

                    }
                    else
                    {
                        Console.WriteLine("ala bilersen");

                    }



                }
                else
                {
                    Console.WriteLine("bele meyve yoxdur");
                }
            }
        }
       
        
    }
}
