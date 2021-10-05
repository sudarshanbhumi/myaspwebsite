using System;

public class FactoryPattern
{

	public static void FactoryDesignPattern()
	{
		Console.WriteLine("Factory pattern ");
        Shape square = FactoryShape.createShape("Square");
        square.getShape();

          Shape circle = FactoryShape.createShape("Circle");
        circle.getShape();

    }
}

public abstract class Shape
{
	public double radius { get; set; }
	public abstract void getShape();
}

class Square : Shape
{

    public override void getShape()
    {
       Console.WriteLine("drawing Square");
    }
}
class Circle : Shape
{
    public override void getShape()
    {
        Console.WriteLine("drawing circle");
    }
}

class FactoryShape
{
    public static Shape createShape(string type)
    {
        if (type == "Square") { return new Square(); }
        else if (type == "Circle") { return new Square(); }
        else return null;
    }
}




