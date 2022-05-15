using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle
{
    private double radius;
    private string color;

    public Circle() { //defaulten
        this.radius = 1.0;
        this.color = "red"; 
    }

   public Circle(double radius)
    {
        this.radius = radius;
        this.color = "red";
    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double getRadius() { return this.radius; }

    public void setRadius(double radius) { this.radius = radius; }  

    public string getColor() { return this.color; } 

    public void setColor(string color) { this.color = color; }
    public double getArea()
    {
        return this.radius * this.radius * Math.PI;
    }

    public override string ToString()
    {
        return "Circle[radius=" + this.radius + " color=" + this.color + "]";

    }

}
