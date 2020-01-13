// Author: Mason Caird & Brycen Martin
// 371-1
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
            string sh1;
            string sh2;
            Shape s = new Shape();
            compare co = new compare();

            // Shape objects
            Square sq = new Square();
            Triangle tri = new Triangle();
            Circle ci = new Circle();
            Octagon oct = new Octagon();
            EqPolygon eq = new EqPolygon();

            // Combination object
            Combination comb = new Combination();

            // Arrays
            string[] shapeNames = new string[8] { "Square", "Triangle", "Circle", "Octagon", "EqPolygon", "Shape", "Compare", "Quit\n"}; // Array of shapes
            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor)); // Array of colors
            string[,] array = new string[10, 10]; // Different combinations for comparison

            Console.WriteLine(" Mason's Shape Calculator");

            // if color is not found keep asking user.
            do
            {
                Console.WriteLine(" What color do you want the background?");
                Console.WriteLine("\n Tip: Capitalize the first letter");
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
                        break;
                    case 1:
                        tri.PrintShape();
                        break;
                    case 2:
                        ci.PrintShape();
                        break;
                    case 3:
                        oct.PrintShape();
                        break;
                    case 4:
                        eq.PrintShape();
                        break;
                    case 5:
                        s.PrintShape();
                        break;

                    case 6:

                        Console.WriteLine("\n Tip: Capitalize first letter of the shape...");

                        // Find the total of Combinations by using the algorithm nCr.
                        double totalCombinations = comb.Ncr_Calculation(shapeNames.Length - 3, 2);

                        // Calculate and examine the different combinations
                        for (int i = 0; i < totalCombinations; i++)
                        {
                            for (int j = i; j <= 4; j++)
                            {
                                if (j != i )
                                {
                                    // 2d Array now stores the different combinations.
                                    array[i, j] = shapeNames[i] + ", " + shapeNames[j];
                                }
                                // Uncomment below if you wanna see the different combinatiosn
                                //Console.WriteLine("Combinations: " + array[i, j]);
                            }
                        }

                        // Prompts the user which shape they want to compare
                        Console.WriteLine("\n1st Shape to compare:");
                        sh1 = Console.ReadLine();
                        Console.WriteLine("\n2nd Shape to compare:");
                        sh2 = Console.ReadLine();

                        // Scan through the array to find the match of comparisons
                        for (int i = 0; i < totalCombinations; i++)
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                // if we find a match, we call a specific function to execute the comparison.
                                if (array[i,j] == sh1 + ", " + sh2 || array[i, j] == sh2 + ", " + sh1) {
                                    
                                    // Im sorry you have to see this....We tried using list of functions, array of functions, hash tables. Nothing was working because our compare class couldnt return a void from a compare object
                                    // and when I try to make it, it says I can't use lambda because my compare type isnt a delegate which I tried to fix too.
                                    // This was our last resort.
                                    // if you look deep into the assignment, we did many other calculations. We did alot of computation and algorithms from discrete Mathematics.
                                    if (sh1 == "Square" && sh2 == "Triangle") { co.CompareArea(sq,tri, sh1,sh2); co.ComparePerimeter(sq, tri, sh1, sh2); }
                                    else if (sh1 == "Triangle" && sh2 == "Square") { co.CompareArea(tri, sq, sh1, sh2); co.ComparePerimeter(tri, sq, sh1, sh2); }
                                    else if (sh1 == "Square" && sh2 == "Circle") { co.CompareArea(sq, ci, sh1, sh2); co.ComparePerimeter(sq, ci, sh1, sh2); }
                                    else if (sh1 == "Circle" && sh2 == "Square") { co.CompareArea(ci, sq, sh1, sh2); co.ComparePerimeter(ci, sq, sh1, sh2); }
                                    else if (sh1 == "Square" && sh2 == "Octagon") { co.CompareArea(sq, oct, sh1, sh2); co.ComparePerimeter(sq, oct, sh1, sh2); }
                                    else if (sh1 == "Octagon" && sh2 == "Square") { co.CompareArea(oct, sq, sh1, sh2); co.ComparePerimeter(oct, sq, sh1, sh2); }
                                    else if (sh1 == "Square" && sh2 == "EqPolygon") { co.CompareArea(sq, eq, sh1, sh2); co.ComparePerimeter(sq, eq, sh1, sh2); }
                                    else if (sh1 == "EqPolygon" && sh2 == "Square") { co.CompareArea(eq, sq, sh1, sh2); co.ComparePerimeter(eq, sq, sh1, sh2); }
                                    else if (sh1 == "Triangle" && sh2 == "Circle") { co.CompareArea(tri, ci, sh1, sh2); co.ComparePerimeter(tri, ci, sh1, sh2); }
                                    else if (sh1 == "Circle" && sh2 == "Triangle") { co.CompareArea(ci, tri, sh1, sh2); co.ComparePerimeter(ci, tri, sh1, sh2); }
                                    else if (sh1 == "Triangle" && sh2 == "Octagon") { co.CompareArea(tri, oct, sh1, sh2); co.ComparePerimeter(tri, oct, sh1, sh2); }
                                    else if (sh1 == "Octagon" && sh2 == "Triangle") { co.CompareArea(oct, tri, sh1, sh2); co.ComparePerimeter(oct, tri, sh1, sh2); }
                                    else if (sh1 == "Triangle" && sh2 == "EqPolygon") { co.CompareArea(tri, eq, sh1, sh2); co.ComparePerimeter(tri, eq, sh1, sh2); }
                                    else if (sh1 == "EqPolygon" && sh2 == "Triangle") { co.CompareArea(eq, tri, sh1, sh2); co.ComparePerimeter(eq, tri, sh1, sh2); }
                                    else if (sh1 == "Circle" && sh2 == "Octagon") { co.CompareArea(ci, oct, sh1, sh2); co.ComparePerimeter(ci, oct, sh1, sh2); }
                                    else if (sh1 == "Octagon" && sh2 == "Circle") { co.CompareArea(oct, ci, sh1, sh2); co.ComparePerimeter(oct, ci, sh1, sh2); }
                                    else if (sh1 == "Circle" && sh2 == "EqPolygon") { co.CompareArea(ci, eq, sh1, sh2); co.ComparePerimeter(ci, eq, sh1, sh2); }
                                    else if (sh1 == "EqPolygon" && sh2 == "Circle") { co.CompareArea(eq, ci, sh1, sh2); co.ComparePerimeter(eq, ci, sh1, sh2); }
                                    else if (sh1 == "Octagon" && sh2 == "EqPolygon") { co.CompareArea(oct, eq, sh1, sh2); co.ComparePerimeter(oct, eq, sh1, sh2); }
                                    else if (sh1 == "EqPolygon" && sh2 == "Octagon") { co.CompareArea(eq, oct, sh1, sh2); co.ComparePerimeter(eq, oct, sh1, sh2); }
                                    else { Console.WriteLine("Error: Try entering a valid shape or capitalize the first letter");}

                                    //
                                }

                            }
                        }

                        break;
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

    class Combination
    {

        // Calculated the different combinations of comparisons.

        public double Ncr_Calculation(int n, int r)
        {
            // nCr algorithm

            int numerator = fact(n);
            int denominator = (fact(r) * fact(n - r));
            return numerator / denominator;
        }

        int fact(int n)
        {
            // starts num 1
            int num = 1;
            
            for (int i = 2; i <= n; i++)
            {
                // if n was 4
                // 1 * 2 * 3 * 4
                num *= i; 
            }

            return num;
        }
    }
}
