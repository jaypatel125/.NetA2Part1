/*
Author: Jay Patel, 000881881
Date: 19/10/2023

Purpose: The code defines an abstract base class "TwoDimension" for two-dimensional geometric shapes within the "Lab2A" program, indicating it's a 2D shape, and serves as a foundation for specific shape classes, but its methods are not yet implemented.

I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
*/
using System;
namespace Lab2A
{
    public class TwoDimension : Shape
    {
        public string dimensions;

        public TwoDimension()
		{
            dimensions = "2d"; // Indicates it's a 2D shape
        }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

