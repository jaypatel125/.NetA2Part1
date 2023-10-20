/*
Author: Jay Patel, 000881881
Date: 19/10/2023

Purpose: The purpose of the provided C# code is to define a "Tetrahedron" class that calculates and stores the area and volume, allows user input for its dimensions, and formats its information for display within a program.

I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
*/
using System;
namespace Lab2A
{
	public class Tetrahedron : ThreeDimension
    {
        private double a;
        private double area;
        private double volume;

        public Tetrahedron()
        {
            Type = "Tetrahedron";
        }

        /// <summary>
        /// Calculates Area
        /// </summary>
        /// <returns> Returns Area </returns>
        public override double CalculateArea()
        {
            // Calculate the surface area 
            area = Math.Pow(3, 1.0 / 3.0) * a * a;
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calculates volume
        /// </summary>
        /// <returns> Returns volume </returns>
        public override double CalculateVolume()
        {
            // Calculate the volume
            volume = (a * a * a) / (6 * Math.Sqrt(2));
            return Math.Round(volume, 2);
        }

        public override void SetData()
        {
            // Prompt the user to input the dimensions
            Console.WriteLine("Enter edge:");
            a = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Formats shape's info in string
        /// </summary>
        /// <returns> Returns formatted string </returns>
        public override string ToString()
        {
            return $" {Type,-15} {dimensions,-15} {CalculateArea(),-15} {CalculateVolume(),-15} ";
        }
    }
}

