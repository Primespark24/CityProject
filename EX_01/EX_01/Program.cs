using System;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool Quit = false;// Keep quit from being true to continue program
            bool ColorFound = false; // Tracks if color is found from user input
            string response; // Holds response from user
            int select; // Keeps number selected for shape
            Shape s = new Shape();
            
            // Arrays
            string[] shapeNames = new string[6] {"Square", "Triangle", "Circle", "Octagon", "EqPolygon", "Shape"}; // Array of shapes
            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor)); // Array of colors

            Console.WriteLine(" Mason's Shape Calculator");

            // keep program running unless user says no to continue
            do
            {
                // if color is not found keep asking user.
                do
                {
                    Console.WriteLine(" What color you want shape Calculator?");
                    s.Color = Console.ReadLine();
                    ColorFound = false;
                    
                    // Checks if user color is valid in the array of Colors
                    foreach (var color in colors)
                    {
                        if (s.Color == Convert.ToString(color))
                        {
                            ColorFound = true;
                        }
                    }

                } while (!ColorFound);

                // Enum Parse to make s.color 
                // Credit https://www.csharp-examples.net/string-to-enum/
                ConsoleColor backg = (System.ConsoleColor)Enum.Parse(typeof(System.ConsoleColor), s.Color);
                
                Console.BackgroundColor = backg;
                Console.Clear();

                do
                {
                    int num = 0;
                    Console.WriteLine("\n Which shape do you to calculate?");
                    Console.WriteLine(" Note: Input number corresponding to shape.\n");

                    // prints outs the number and shape array
                    foreach (string i in shapeNames)
                    {
                        Console.WriteLine("  {0}: {1}", num, i);
                        num++;
                    }

                    // read input from user to select shape
                    select = Convert.ToInt32(Console.ReadLine());

                } while (select < 0 || select > 5);

                // Switch statement to make new shape object and read perimeter
                switch (select)
                {
                    case 0:
                        Shape sq = new Square();
                        sq.GetPerimeter();
                        break;
                    case 1:
                        Shape tri = new Triangle();
                        tri.GetPerimeter();
                        break;
                    case 2:
                        Shape ci = new Circle();
                        ci.GetPerimeter();
                        break;
                    case 3:
                        Shape oct = new Octagon();
                        oct.GetPerimeter();
                        break;
                    case 4:
                        Shape eq = new EqPolygon();
                        eq.GetPerimeter();
                        break;
                    case 5:
                        Shape sh = new Shape();
                        sh.GetPerimeter();
                        break;
                }

                // Prompts user to continue
                Console.WriteLine(" Do you want to continue? Yes No");
                response = Console.ReadLine();

                // if no, quit is true and terminates program
                if (response.Contains("no"))
                {
                    Quit = true;
                }

            } while (!Quit);
        }
    }
}
