using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int ulit = 0;

            Console.WriteLine("==THis is a Loop Program==");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("How many times do you want to print your name: ");
            ulit = int.Parse(Console.ReadLine());

            int l = 0;
            do
            {
                Console.WriteLine(name);
                l++;
                if (l == 2)
                {
                    goto part2;
                }
                if (l ==3 )
                {
                    break;
                }
            } while (l < ulit);

        part1:
            Console.WriteLine("part 1");
        part2:
            Console.WriteLine("part 2");


            {
                /*                for (int i = 0; i < ulit; i++)
                                {
                                    Console.WriteLine(name);
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.WriteLine($" {name}");
                                    }
                                }*/
            }
            { 

                //int origulit;
                //origulit = ulit;
                //    Console.WriteLine("While v2");
                //int a = 0;
                //while (a < ulit)
                //{
                //    Console.WriteLine(name);
                //    a++;

                //    Console.WriteLine("");                
                //    while (origulit > 0)
                //    {
                //        Console.WriteLine("While sa loob");
                //        Console.WriteLine($"  {name}");
                //        origulit--;  //ulit = ulit -1;
                //    }
                //}
            }
            Console.ReadLine();
        }
    }
}

