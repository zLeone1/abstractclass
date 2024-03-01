using System;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Square : Shape
{
    public double side { get; set; }

     
    public Square(double side)
    {
        this.side = side;
    }

    public override double CalculateArea()
    {
        return side * side;
    }
}

public class Circulo : Shape
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radio * Radio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square(5);

        Console.WriteLine("Square area: " + mySquare.CalculateArea());

        Circulo myCircle = new Circulo(3);

        Console.WriteLine("Circle area: " + myCircle.CalculateArea());
    }
}
