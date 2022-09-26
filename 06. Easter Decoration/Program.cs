using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {

            int costomers = int.Parse(Console.ReadLine());
            double price = 0;
            for (int i = 0; i < costomers; i++)
            {
                string type = Console.ReadLine();
                double sum = 0;
                double br = 0;
                while (type != "Finish")
                {
                    
                    br++;
                        switch (type)
                    {

                        case "basket":
                            sum += 1.5;
                            break;
                        case "wreath":
                            sum += 3.8;
                            break;
                        case "chocolate bunny":
                            sum += 7;
                            break;
                        default:
                            break;
                    }

                    type = Console.ReadLine();
                }
                
                if (br % 2 == 0)
                {
                    sum = sum - sum * 0.2;
                }
                else
                {
                    sum = sum;
                }

                Console.WriteLine($"You purchased {br} items for {sum:f2} leva.");


                price += sum;


            }



            Console.WriteLine($"Average bill per client is: {(price / costomers):f2} leva.");

        }
    }
}
