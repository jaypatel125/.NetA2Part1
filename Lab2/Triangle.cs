/*
Author: Jay Patel, 000881881
Date: 19/10/2023

Purpose: The purpose of the provided C# code is to define a "Triangle" class that calculates and stores the area, allows user input for its dimensions, and formats its information for display within a program.

I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
*/
using System;
namespace Lab2A
{
	public class Triangle : TwoDimension
	{
        private double height;
        private double base1;
        private double area;

        public Triangle()
		{
			Type = "Triangle";
        }

        /// <summary>
        /// Calculates Area
        /// </summary>
        /// <returns> Returns Area </returns>
        public override double CalculateArea()
        {
            // Calculate the surface area 
            area = (height * base1) / 2;
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calculates volume
        /// </summary>
        /// <returns> Returns 0 </returns>
        public override double CalculateVolume()
        {
            // A Triangle is a 2D shape, so its volume is 0
            return 0;
        }

        public override void SetData()
        {
            // Prompt the user to input the dimensions
            Console.WriteLine("Enter height:");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter base:");
            base1 = double.Parse(Console.ReadLine());
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

