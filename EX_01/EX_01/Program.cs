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
            Validation v = new Validation();

            // Arrays
            string[] shapeNames = new string[7] { "Square", "Triangle", "Circle", "Octagon", "EqPolygon", "Shape", "Compare"}; // Array of shapes
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

                } while (select < 0 || select > 5);

                // Switch statement to make new shape object and read perimeter
                switch (select)
                {
                    case 0:
                        Shape sq = new Square();
                        sq.GetPerimeter();
                        sq.GetArea();
                        if (v.CheckShapeStatus(sq) == false)
                        {
                            Console.WriteLine("Square hasn't been modified yet");
                            Console.WriteLine("Enter Square Side Length: ");
                            double sqLength = Convert.ToDouble(Console.ReadLine());
                            //sq.GetArea();
                            //sq.GetPerimeter();
                        }
                        break;
                    case 1:
                        Shape tri = new Triangle();
                        tri.GetPerimeter();
                        tri.GetArea();
                        break;
                    case 2:
                        Shape ci = new Circle();
                        ci.GetPerimeter();
                        ci.GetArea();
                        break;
                    case 3:
                        Shape oct = new Octagon();
                        oct.GetPerimeter();
                        oct.GetArea();
                        break;
                    case 4:
                        Shape eq = new EqPolygon();
                        eq.GetPerimeter();
                        eq.GetArea();
                        break;
                    case 5:
                        Shape sh = new Shape();
                        sh.GetPerimeter();
                        sh.GetArea();
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

    class questions
    {
        public void shapeQuestions(Shape s)
        {
            
        }
    }

    // Checks if the shape has been seen before
    class Validation
    {
        public bool CheckShapeStatus(Shape s)
        {
            if (s.GetArea() == 0 || s.GetPerimeter() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
