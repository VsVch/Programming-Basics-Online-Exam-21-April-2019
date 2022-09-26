using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numEggs = int.Parse(Console.ReadLine());
            int colourRed = 0;
            int colourOrange = 0;
            int colourBlue = 0;
            int colourGreen = 0;
            int maxColour = 0;
            string colr = "";


            for (int i = 0; i < numEggs ; i++)
            {
                
                string colour = Console.ReadLine();
                switch (colour)
                {
                    case "red":
                        colourRed++;
                        break;
                    case "orange":
                        colourOrange++;
                        break;
                    case "blue":
                        colourBlue++;
                        break;
                    case "green":
                        colourGreen++;
                        break;

                    default:
                        break;
                }






                for (int j = 0; j < 4; j++)
                {
                    if (colourRed > maxColour)
                    {
                        maxColour = colourRed;
                        colr = "red";
                    }
                    if (colourOrange > maxColour)
                    {
                        maxColour = colourOrange;
                        colr = "orange";
                    }
                    if (colourBlue > maxColour)
                    {
                        maxColour = colourBlue;
                        colr = "blue";
                    }
                    if (colourGreen > maxColour)
                    {
                        maxColour = colourGreen;
                        colr = "green";
                    }
                }

                



                

            }


            Console.WriteLine($"Red eggs: {colourRed}");
            Console.WriteLine($"Orange eggs: {colourOrange}");
            Console.WriteLine($"Blue eggs: {colourBlue}");
            Console.WriteLine($"Green eggs: {colourGreen}");
            Console.WriteLine($"Max eggs: {maxColour} -> {colr}");



        }
    }
}
