using System;

public class Circle : Shape
{
	public Circle(double radius)
	{
		Radius = radius;
	}

	public override double GetArea(double radius)
	{
		return 2 * 3.14 * radius;
	}

}
