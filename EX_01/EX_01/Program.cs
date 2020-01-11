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

            // Shape objects
            Square sq = new Square();
            Triangle tri = new Triangle();
            Circle ci = new Circle();
            Octagon oct = new Octagon();
            EqPolygon eq = new EqPolygon();

            // Arrays
            string[] shapeNames = new string[8] { "Square", "Triangle", "Circle", "Octagon", "EqPolygon", "Shape", "Compare", "Quit"}; // Array of shapes
            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor)); // Array of colors

            Console.WriteLine(" Mason's Shape Calculator");

            // if color is not found keep asking user.
            do
            {
                Console.WriteLine(" What color do you want the background?");
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

            // keep program running unless user says yes to quit
            do
            {

                do
                {
                    int num = 0;
                    Console.WriteLine("\n Which shape do you wanna look at?");
                    Console.WriteLine(" Note: Input number corresponding to shape.\n");

                    // prints outs the number and shape array
                    foreach (string i in shapeNames)
                    {
                        Console.WriteLine("  {0}: {1}", num, i);
                        num++;
                    }

                    // read input from user to select shape
                    select = Convert.ToInt32(Console.ReadLine());

                } while (select < 0 || select > 7);

                // Switch statement to make new shape object and read perimeter
                switch (select)
                {
                    case 0:

                        sq.PrintShape();
                        Console.ReadLine();
                        break;
                    case 1:
                        tri.PrintShape();
                        Console.ReadLine();
                        break;
                    case 2:
                        ci.PrintShape();
                        Console.ReadLine();
                        break;
                    case 3:
                        oct.PrintShape();
                        Console.ReadLine();
                        break;
                    case 4:
                        eq.PrintShape();
                        Console.ReadLine();
                        break;
                    case 5:
                        s.PrintShape();
                        Console.ReadLine();
                        break;

                    case 6:
                    // Compare

                    case 7:
                        // Prompts user to quit
                        Console.WriteLine(" Do you want to quit? Yes No");
                        response = Console.ReadLine();
                        // if no, quit is true and terminates program
                        if (response.Contains("yes"))
                        {
                            Quit = true;
                        }

                        break;
                }

            } while (!Quit);
        }
    }
}
