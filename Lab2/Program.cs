/*
Author: Jay Patel, 000881881
Date: 19/10/2023

Purpose: The C# program "Lab2A" provides a menu-driven console application for creating, storing, and displaying information about various geometric shapes.

I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            int count = 0;

            // Display a menu and handle user input
            bool toggle = true;
            while (toggle)
            {
                // Display the menu
                string menu =
    @"
=======================================================
|                 List of Shapes                      |
=======================================================
| 1. Rectangle      | 2. Square      | 3. Box         |
|-----------------------------------------------------|
| 4. Cube           | 5. Ellipse     | 6. Circle      |
|-----------------------------------------------------|
| 7. Cylinder       | 8. Sphere      | 9. Triangle    |
|-----------------------------------------------------|
| 10. Tetrahedron   | 0. EXIT        |                |
=======================================================
Select Shape: ".Trim();
                Console.WriteLine("\nYou have made " + count + " shapes.");
                Console.WriteLine(menu);
                string input = Console.ReadLine();

                // Switch case for each option
                switch (input)
                {
                    // Case 1: Add a Rectangle
                    case "1":
                        Shape Rectangle = new Rectangle();
                        Rectangle.SetData();
                        Shapes.Add(Rectangle);
                        count++;
                        break;

                    // Case 2: Add a Square
                    case "2":
                        Shape Square = new Square();
                        Square.SetData();
                        Shapes.Add(Square);
                        count++;
                        break;

                    // Case 3: Add a Box
                    case "3":
                        Shape Box = new Box();
                        Box.SetData();
                        Shapes.Add(Box);
                        count++;
                        break;

                    // Case 4: Add a Cube
                    case "4":
                        Shape Cube = new Cube();
                        Cube.SetData();
                        Shapes.Add(Cube);
                        count++;
                        break;

                    // Case 5: Add an Ellipse
                    case "5":
                        Shape Ellipse = new Ellipse();
                        Ellipse.SetData();
                        Shapes.Add(Ellipse);
                        count++;
                        break;

                    // Case 6: Add a Circle
                    case "6":
                        Shape Circle = new Circle();
                        Circle.SetData();
                        Shapes.Add(Circle);
                        count++;
                        break;

                    // Case 7: Add a Cylinder
                    case "7":
                        Shape Cylinder = new Cylinder();
                        Cylinder.SetData();
                        Shapes.Add(Cylinder);
                        count++;
                        break;

                    // Case 8: Add a Sphere
                    case "8":
                        Shape Sphere = new Sphere();
                        Sphere.SetData();
                        Shapes.Add(Sphere);
                        count++;
                        break;

                    // Case 9: Add a Triangle
                    case "9":
                        Shape Triangle = new Triangle();
                        Triangle.SetData();
                        Shapes.Add(Triangle);
                        count++;
                        break;

                    // Case 10: Add a Tetrahedron
                    case "10":
                        Shape Tetrahedron = new Tetrahedron();
                        Tetrahedron.SetData();
                        Shapes.Add(Tetrahedron);
                        count++;
                        break;

                    // Case 0: Display the list of shapes and exit the program
                    case "0":
                        Console.WriteLine("\nTotal shapes: " + count);
                        Console.WriteLine("List of Shapes:");
                        Console.WriteLine("=============================================================");
                        Console.WriteLine($" {"Type",-15} {"Dimensions",-15} {"Area",-15} {"Volume",-15} ");
                        Console.WriteLine("=============================================================");
                        foreach (Shape currentShape in Shapes)
                        {
                            Console.WriteLine(currentShape.ToString());
                            Console.WriteLine("-------------------------------------------------------------");
                        }
                        toggle = false;

                        break;


                    // Default case: Invalid input
                    default:
                        {
                            Console.WriteLine("Try Again. Enter from above options.\n");
                            break;
                        }
                }
            }
        }
    }
}
