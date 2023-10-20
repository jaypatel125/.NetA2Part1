/*
Author: Jay Patel, 000881881
Date: 19/10/2023

Purpose: The purpose of the provided C# code is to define a "Cube" class that calculates and stores the area and volume, allows user input for its dimensions, and formats its information for display within a program.

I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
*/
using System;
namespace Lab2A
{
	public class Cube : ThreeDimension
    {
        private double length;
        private double area;
        private double volume;

        public Cube()
        {
            Type = "Cube";
        }

        /// <summary>
        /// Calculates Area
        /// </summary>
        /// <returns> Returns Area </returns>
        public override double CalculateArea()
        {
            // Calculate the surface area 
            area = 6 * length;
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calculates volume
        /// </summary>
        /// <returns> Returns volume </returns>
        public override double CalculateVolume()
        {
            // Calculate the volume
            volume = length * length * length;
            return Math.Round(volume, 2);
        }

        public override void SetData()
        {
            // Prompt the user to input the dimensions
            Console.WriteLine("Enter length:");

            length = double.Parse(Console.ReadLine());
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

