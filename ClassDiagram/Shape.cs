using System;

public class Shape
{
	public double Length { get; set; }
	public double Width { get; set; }

	

	public virtual double GetArea(double length, double width)
	{
	      double area = length * width;
		return area;
	}

	public virtual double GetPerimeter(double length, double width)
	{
		double perimeter = 2 * (length + width);
		return perimeter;
	}
}
