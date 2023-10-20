/*
Author: Jay Patel, 000881881
Date: 19/10/2023

Purpose: The purpose of the provided C# code is to define a "Ellipse" class that calculates and stores the area, allows user input for its dimensions, and formats its information for display within a program.

I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
*/
using System;
namespace Lab2A
{
	public class Ellipse : TwoDimension
    {
        private double a;
        private double b;
        private double area;

        public Ellipse()
        {
            Type = "Ellipse";
        }

        /// <summary>
        /// Calculates Area
        /// </summary>
        /// <returns> Returns Area </returns>
        public override double CalculateArea()
        {
            // Calculate the surface area 
            area = PI * a * b;
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calculates volume
        /// </summary>
        /// <returns> Returns 0 </returns>
        public override double CalculateVolume()
        {
            // A Ellipse is a 2D shape, so its volume is 0
            return 0;
        }

        public override void SetData()
        {
            // Prompt the user to input the dimensions
            Console.WriteLine("Enter a Axis:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b Axis:");
            b = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Formats shape's info in string
        /// </summary>
        /// <returns> Returns formatted string </returns>
        public override string ToString()
        {
            return $" {Type,-15} {dimensions,-15} {CalculateArea(),-15} ";
        }
    }
}

